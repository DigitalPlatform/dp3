using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DigitalPlatform.RestClient
{
    /// <summary>
    /// 通道包装对象
    /// </summary>
    public class ChannelWrapper
    {
        /// <summary>
        /// 通道是否正在使用中
        /// </summary>
        public bool InUsing = false;

        /// <summary>
        /// 通道对象
        /// </summary>
        public RestChannel Channel = null;
    }

    public class RestChannelPool : List<ChannelWrapper>
    {
        /// <summary>
        /// 最多通道数
        /// </summary>
        public int MaxCount = 50;

        //允许多个线程同时处于读取模式，但同一时间只允许一个线程写入模式，因此也称作共享-独占锁
        internal ReaderWriterLockSlim m_lock = new ReaderWriterLockSlim();
        internal static int m_nLockTimeout = 5000;  // 5000=5秒

        /// <summary>
        /// 征用一个通道
        /// </summary>
        /// <param name="strUrl">服务器 URL</param>
        /// <param name="strUserName">用户名</param>
        /// <returns>返回通道对象</returns>
        public RestChannel GetChannel(string strUrl,
            string strUserName)
        {
            ChannelWrapper wrapper = null;

            if (this.m_lock.TryEnterWriteLock(m_nLockTimeout) == false)
                throw new LockException("锁定尝试中超时");
            try
            {
                // 先从池中查找存在此url的空闭通道
                wrapper = this.GetChannelInternel(strUrl, strUserName, true);
                if (wrapper != null)
                    return wrapper.Channel;

                //超出数量，需清理不用的通道
                if (this.Count >= MaxCount)
                {
                    // 清理不用的通道
                    int nDeleteCount = CleanChannel(false);
                    if (nDeleteCount == 0)
                    {
                        // 全部都在使用
                        throw new Exception("通道池已满，请稍候重试获取通道");
                    }
                }

                // 没有找到,则new一个
                RestChannel channel = new RestChannel()
                {
                    Url = strUrl,
                    UserName = strUserName
                };
                
                wrapper = new ChannelWrapper();
                wrapper.Channel = channel;
                wrapper.InUsing = true;

                // 加到集合里
                this.Add(wrapper);

                // 返回
                return channel;
            }
            finally
            {
                this.m_lock.ExitWriteLock(); //释放锁
            }
        }

        /// <summary>
        /// 归还一个通道
        /// </summary>
        /// <param name="channel">通道对象</param>
        public void ReturnChannel(RestChannel channel)
        {
            ChannelWrapper wrapper = null;
            if (this.m_lock.TryEnterReadLock(m_nLockTimeout) == false)
                throw new LockException("锁定尝试中超时");
            try
            {
                wrapper = this.GetChannelInternel(channel);
                if (wrapper != null)
                    wrapper.InUsing = false;
            }
            finally
            {
                this.m_lock.ExitReadLock();
            }
        }

        // 从池中查找指定URL的LibraryChannel对象
        private ChannelWrapper GetChannelInternel(string strUrl,
            string strUserName,
            bool bAutoSetUsing)
        {
            foreach (ChannelWrapper wrapper in this)
            {
                if (wrapper.InUsing == false
                    && wrapper.Channel.Url == strUrl
                    && wrapper.Channel.UserName == strUserName)
                {
                    if (bAutoSetUsing == true)
                        wrapper.InUsing = true;
                    return wrapper;
                }
            }

            return null;
        }

        // 查找指定的LibraryChannel对象
        ChannelWrapper GetChannelInternel(RestChannel inner_channel)
        {
            foreach (ChannelWrapper channel in this)
            {
                if (channel.Channel == inner_channel)
                {
                    return channel;
                }
            }

            return null;
        }


        // 清理不用的通道
        // return:
        //      清理掉的通道数目
        int CleanChannel(bool bLock)
        {
            // 要需清理的放到内存里
            List<ChannelWrapper> deletes = new List<ChannelWrapper>();

            if (bLock == true)
            {
                if (this.m_lock.TryEnterWriteLock(m_nLockTimeout) == false)
                    throw new LockException("锁定尝试中超时");
            }
            try
            {
                for (int i = 0; i < this.Count; i++)
                {
                    ChannelWrapper wrapper = this[i];
                    if (wrapper.InUsing == false)
                    {
                        this.RemoveAt(i);
                        i--;
                        deletes.Add(wrapper);
                    }
                }
            }
            finally
            {
                if (bLock == true)
                    this.m_lock.ExitWriteLock();
            }

            // 关闭这些通道
            foreach (ChannelWrapper wrapper in deletes)
            {
                //wrapper.Channel.BeforeLogin -= new BeforeLoginEventHandle(channel_BeforeLogin);
                wrapper.Channel.Close();
            }

            return deletes.Count;
        }

    }

    public class LockException : Exception
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="error"></param>
        /// <param name="strText"></param>
        public LockException(string strText)
            : base(strText)
        {
        }
    }
}
