using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CSL0662_project
{
    class User_db
    {

        public User_db()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string Names
    {
        get;
        set;
    }

    public string Username
    {
        get;
        set;
    }


    public string Password
    {
        get;
        set;
    }

    public string Usertype
    {
        set;
        get;

    }

    public string Fees
    {
        set;
        get;

    }

    public string Course
    {
        set;
        get;

    }
    public string Student
    {
        set;
        get;
    }

    public void Getdata(DataGridView dg)
    {
        Businesslogic bl = new Businesslogic();
        string query = "select * from Student";
        bl.filldataGrid(dg, query);
    }

    public void getdata(DataGridView dg)
    {
        Businesslogic bl = new Businesslogic();
        string query = "select * from signup";
        bl.filldataGrid(dg, query);
    }

    public void getdatabysearch(DataGridView dg,String se)
    {
        Businesslogic bl = new Businesslogic();
        string query = "select * from signup where Username like ('%" + se + "%')";
        bl.filldataGrid(dg, query);
    }


    public void Addcourse(User_db udb)
    {
        string query = String.Format("insert into courses values ('{0}','{1}','{2}')",
            udb.Names, udb.Fees, udb.Course);
        Businesslogic BL = new Businesslogic();
        BL.Nonquery(query);
    }

   

    public void Insertuser(User_db udb)
    {
        string query = String.Format("insert into signup values ('{0}','{1}','{2}','{3}')",
            udb.Username, udb.Names, udb.Password, udb.Usertype);
        Businesslogic BL = new Businesslogic();
        BL.Nonquery(query);
    }

    public void DeleteUser(User_db udb)
    {
        string query = String.Format("Delete from signup where Username='{0}'", udb.Username);
        Businesslogic BL = new Businesslogic();
        BL.Nonquery(query);
    }

    public void changepassword(User_db udb)
    {
        string query = String.Format("update [signup] set [Password]='{0}' where [Username]='{1}'", udb.Password, udb.Username);
        Businesslogic BL = new Businesslogic();
        BL.Nonquery(query);
    
    }



    public bool Authenticated(User_db udb)
    {
        string query = string.Format("select * from signup where Username='{0}' and Password='{1}' and Usertype='{2}'", udb.Username, udb.Password, udb.Usertype);
        Businesslogic BL = new Businesslogic();
        OleDbDataReader rec = BL.SelectQuery(query);
        if (rec.Read())
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public void fillcombo(ComboBox cb)
    {
        string query = "select Username from signup";
        Businesslogic BL = new Businesslogic();
        OleDbDataReader rec = BL.SelectQuery(query);
        while (rec.Read())
        {
            cb.Items.Add(rec[0].ToString());
        }
    }
   
/*
    public void FillRepeater(Repeater Rep)
    {
        string query = "select * from aditya";
        Businesslogic BL = new Businesslogic();
        System.Data.DataSet ds = BL.Adapter(query);
        Rep.DataSource = ds;
        Rep.DataBind();

    }   */


    }
}
