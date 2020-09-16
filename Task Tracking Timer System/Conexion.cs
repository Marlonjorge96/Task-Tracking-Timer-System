using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracking_Timer_System
{
    public abstract class Conexion
    {

        private readonly string conn;

        public Conexion() {

            conn = ("Data Source=SV9465-8CQN382;Initial Catalog=sistema;Integrated Security=True;Context Connection=False");
        }
        protected SqlConnection getConnection()
        {
            return new SqlConnection(conn);
        }
    } 
}
