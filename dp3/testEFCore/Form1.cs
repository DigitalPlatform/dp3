using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testEFCore
{
    public partial class Form1 : Form
    {
        // 数据库对象
        SimpleDataStorage _dbclient = null;

        public Form1()
        {
            InitializeComponent();

            //创建sqlite数据库
            this.ConnectionDb();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 消毁对象
            this._dbclient.Dispose();
        }

        #region 数据库函数

        /// <summary>
        /// 创建数据库和表
        /// </summary>
        public void ConnectionDb()
        {
            this._dbclient = new SimpleDataStorage();
            //Create the database file at a path defined in SimpleDataStorage
            this._dbclient.Database.EnsureCreated();

            //Create the database tables defined in SimpleDataStorage
            this._dbclient.Database.Migrate();

            //this._dbclient.Remove(Cat);
        }

        /// <summary>
        /// 创建记录
        /// </summary>
        public void AddCate()
        {
            for (int i = 0; i < 10; i++)
            {
                this._dbclient.Cats.Add(new Cat() { Name = "Caty McCat: " + i });
            }
            this._dbclient.SaveChanges(true);
        }


        #endregion



        private void button_addCat_Click(object sender, EventArgs e)
        {
            this.AddCate();
        }

        private void button_getCat_Click(object sender, EventArgs e)
        {

            List<Cat> cats = this._dbclient.Cats.ToList();

            string text = "";
            foreach (Cat cat in cats)
            {
                text += cat.Id + "--" + cat.Name + "\r\n";
            }
            MessageBox.Show(this, text);
        }
    }
}
