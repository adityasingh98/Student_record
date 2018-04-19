using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.OleDb;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace CSL0662_project
{
    class Businesslogic
    {

        	public Businesslogic()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    OleDbConnection cn;
    OleDbCommand cmd;

    public void Openconnection()
    {
        string constring = ConfigurationManager.ConnectionStrings["constr"].ToString();
        cn = new OleDbConnection(constring);
        if (cn.State == ConnectionState.Closed)
        {
            cn.Open();
        }
    }
    public OleDbDataReader SelectQuery(string query)
    {
        Openconnection();
        cmd = new OleDbCommand(query, cn);
        OleDbDataReader rec = cmd.ExecuteReader();
        return rec;



    }


    public void Closeconnection()
    {
        if (cn.State == ConnectionState.Open)
        {
            cn.Close();
        }
    }

    public void Nonquery(string query)
    {
        Openconnection();
        cmd = new OleDbCommand(query, cn);
        cmd.ExecuteNonQuery();
        Closeconnection();
    }

    public DataSet Adapter(string Query)
    {
         Openconnection();
        cmd = new OleDbCommand(Query, cn);
        OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        return ds;
    }

    public void filldataGrid(DataGridView dg, String query)
    {
        Openconnection();
        cmd = new OleDbCommand(query, cn);
        OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        dg.DataSource = ds.Tables[0];


    }

    }
}
