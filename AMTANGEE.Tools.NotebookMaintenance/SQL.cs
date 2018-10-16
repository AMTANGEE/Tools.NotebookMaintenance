using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AMTANGEE.Tools.NotebookMaintenance
{
    public class MSSQL
    {

        public event ExceptionEventHandler SQLException;
        public delegate void ExceptionEventHandler(Exception exc, string additonalInfo);
        bool logStatements = false;
        public MSSQL()
        {
        }

        public MSSQL(bool LogSql)
        {
            logStatements = LogSql;
        }

        static string prefix = "MSSQL";
        public MSSQL(bool LogSql, string logPrefix)
        {
            logStatements = LogSql;
            prefix = logPrefix;
        }

        public static DataSet ToDataSet(string AXMLString)
        {
            DataSet vXMLDS = null;
            if (AXMLString.Length > 0)
            {
                try
                {
                    vXMLDS = new DataSet();
                    System.IO.TextReader tr = System.IO.TextReader.Null;
                    AXMLString = AXMLString.Replace("\n", "");
                    AXMLString = AXMLString.Replace("\r", "");
                    System.Xml.XmlTextReader xmltr = new System.Xml.XmlTextReader(new System.IO.StringReader(AXMLString));
                    vXMLDS.ReadXml(xmltr);
                }
                catch
                {
                    vXMLDS = null;
                }
            }
            return vXMLDS;
        }

        internal bool SQLExecute(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException exc)
            {
                if (SQLException != null)
                    SQLException(exc, "SQL: " + command.CommandText);
                
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }


        public bool SQLExecute(string AStringToExecute, SqlConnection sqlCon)
        {
            return SQLExecute(AStringToExecute, sqlCon, true);
        }

        public bool SQLExecute(string AStringToExecute, SqlConnection sqlCon, bool ignoreException)
        {
            AStringToExecute = AStringToExecute.Replace(" GO ", "");

            SqlCommand vCommand = new SqlCommand(AStringToExecute, sqlCon);
            SqlCommand vCommandArith = new SqlCommand("SET ARITHABORT ON", sqlCon);

            try
            {
                sqlCon.Open();
                vCommandArith.ExecuteNonQuery();
                vCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException exc)
            {
                if (SQLException != null)
                    SQLException(exc, "SQL: " + vCommand.CommandText);
               
                if (!ignoreException)
                    throw;

                return false;
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public DataSet SQLSelect(string ASelectString, SqlConnection sqlCon)
        {
            return SQLSelect(ASelectString, sqlCon, true);
        }

        public DataSet SQLSelect(string ASelectString, SqlConnection sqlCon, bool ignoreException)
        {
            using (DataSet local = new DataSet())
            {

                SqlDataAdapter da = new SqlDataAdapter(ASelectString, sqlCon);
                da.SelectCommand.CommandTimeout = 600;
                int vAnzahl = 0;
                try
                {
                    sqlCon.Open();
                    vAnzahl = da.Fill(local, "Table1");
                }
                catch (SqlException exc)
                {
                    if (SQLException != null)
                        SQLException(exc, "SQL: " + da.SelectCommand.CommandText);
                   
                    if (!ignoreException)
                        throw;
                }
                finally
                {
                    sqlCon.Close();
                }

                if (vAnzahl > 0)
                {
                    return local;
                }
            }
            return null;

        }

        public bool SQLExists(string ASelectString, SqlConnection sqlCon)
        {
            return SQLExists(ASelectString, sqlCon, true);
        }

        public bool SQLExists(string ASelectString, SqlConnection sqlCon, bool ignoreException)
        {
            using (DataSet ds = SQLSelect(ASelectString, sqlCon, ignoreException))
            {
                if (ds == null)
                    return false;

                return true;
            }
        }

        public string SQLExecuteScalar(string ASelectString, SqlConnection sqlCon)
        {
            return SQLExecuteScalar(ASelectString, sqlCon, true);
        }

        public string SQLExecuteScalar(string ASelectString, SqlConnection sqlCon, bool ignoreException)
        {
            SqlCommand vCommand = new SqlCommand(ASelectString, sqlCon);
            vCommand.CommandTimeout = 600;

            string vObject = "";
            try
            {
                sqlCon.Open();
                object vObj = vCommand.ExecuteScalar();
                if (vObj != null)
                    vObject = vObj.ToString();

            }
            catch (Exception exc)
            {
                if (SQLException != null)
                    SQLException(exc, "SQL: " + vCommand.CommandText);
               
                vObject = "";

                if (!ignoreException)
                    throw;
            }
            finally
            {
                sqlCon.Close();
            }

            return vObject;
        }

        public static string CleanSQLString(string ASqlString)
        {
            ASqlString = ASqlString.Replace("'", "''");
            return ASqlString;
        }
    }
}
