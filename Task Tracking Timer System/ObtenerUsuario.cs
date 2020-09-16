using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracking_Timer_System
{
    class ObtenerUsuario : Conexion
    {
        string mensaje = "";
        public bool login(string usuario, string password) {
            using (var conexion = getConnection()) {
                conexion.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = conexion;
                    command.CommandText = "select * from login where Email=@usu and clave=@pass ";
                    command.Parameters.AddWithValue("@usu", usuario.ToString());
                    command.Parameters.AddWithValue("@pass", password.ToString());
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) {
                        return true;
                    }
                    else {
                        return false;
                    }

                }
            };
        }

        public string Insertar(string codtarea, string tarea)
        {
            try
            {
                using (var conexion = getConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "insert into tareas (tipo_tarea,codtarea) values(@tarea,@codtarea)";
                        command.Parameters.AddWithValue("@tarea", tarea.ToString());
                        command.Parameters.AddWithValue("@codtarea", codtarea.ToString());
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        return mensaje = "registros insertados correctamente";
                    }
                };
            }
            catch
            {
                return mensaje = "Error al ingresar los registro...";
                throw;
            }

        }

        public string Eliminar(int id)
        {
            try
            {
                using (var conexion = getConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.Parameters.AddWithValue("@id", id);
                        command.CommandText = "delete from tareas where idtarea=@id";
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        return mensaje = "registro eliminado correctamente";
                    }
                };
            }
            catch
            {
                return mensaje = "Error al eliminar los registro...";
                throw;
            }
        }

        public string Buscar(string valorbuscar,int id)
        {
            try
            {
                //var cambio = valorbuscar;
                using (var conexion = getConnection())
                {
                    conexion.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@tipo_tarea", valorbuscar);
                        command.Parameters.AddWithValue("@codtarea", valorbuscar);                        
                        command.CommandText = "select * from tareas where idtarea=@id or tipo_tarea=@tipo_tarea or codtarea=@codtarea";                                                
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        return mensaje = "registro correctamente";
                    }
                };
            }
            catch
            {
                return mensaje = "Error al buscar los registro...";
                throw;
            }


        }

        public bool UpdateUser(string email,string newpass)
        {
            
            var conexion = getConnection();
            conexion.Open();
            var sql = "select Email from login";
            SqlCommand command = new SqlCommand(sql, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conexion);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            SqlDataReader reader = command.ExecuteReader();
            int v = tabla.Rows.Count;

            if (reader.HasRows == true)
            {
                int i = 0;
                while (reader.Read())
                {
                    string verdadero = "";
                    foreach (DataRow row in tabla.AsEnumerable())
                    {
                        string rowss = row.ItemArray[0].ToString();
                        if (email.ToString().Trim() == row.ItemArray[0].ToString().Trim())
                        {
                            verdadero = email;
                        }
                        
                    }
                    if (email == verdadero)
                    {
                        reader.Close();
                        conexion.Close();
                        using (var conex = getConnection())
                        {
                            conexion.Open();
                            using (var commands = new SqlCommand())
                            {
                                commands.Connection = conexion;                                
                                commands.CommandText = "update login set clave =@clave where Email=@email";
                                commands.Parameters.AddWithValue("@clave", newpass.ToString());
                                commands.Parameters.AddWithValue("@email", email.ToString());
                                commands.CommandType = CommandType.Text;
                                commands.ExecuteNonQuery();

                            } 
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (reader.HasRows == false)
            {
                reader.Close();
                return true;
            }
            return false;
        }


        public bool SignIn(string users, string lastName,string email, string pass)
        {
            var conexion = getConnection();       
            conexion.Open();
            var sql = "select * from login";
            SqlCommand command = new SqlCommand(sql, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conexion);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            SqlDataReader reader = command.ExecuteReader();
            int v = tabla.Rows.Count;           

            if (reader.HasRows == true)
            {
                int i = 0;
                while (reader.Read())
                {
                    string verdadero = "";
                    int conteo = 0;
                    foreach (DataRow row in tabla.AsEnumerable())
                    {
                        string rowss = row.ItemArray[4].ToString();
                        if (email.ToString().Trim() == row.ItemArray[4].ToString().Trim())
                        {
                            verdadero = email;
                        }
                        conteo++;
                    }
                    if (email != verdadero)
                    {
                        reader.Close();

                        command.Connection = conexion;
                        command.CommandText = "insert into login (usuario,LastName,clave,Email)values (@user,@lastName,@pass,@email)";
                        command.Parameters.AddWithValue("@user", users.ToString());
                        command.Parameters.AddWithValue("@lastName", lastName.ToString());
                        command.Parameters.AddWithValue("@email", email.ToString());
                        command.Parameters.AddWithValue("@pass", pass.ToString());
                        command.CommandType = CommandType.Text;                        
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (reader.HasRows == false)
            {
                reader.Close();
                conexion.Close();
                using (var conex = getConnection())
                {
                    conexion.Open();
                    using (var commands = new SqlCommand())
                    {
                        commands.Connection = conexion;
                        commands.CommandText = "insert into login (usuario,LastName,clave,Email)values (@user,@lastName,@pass,@email)";
                        commands.Parameters.AddWithValue("@user", users.ToString());
                        commands.Parameters.AddWithValue("@lastName", lastName.ToString());
                        commands.Parameters.AddWithValue("@email", email.ToString());
                        commands.Parameters.AddWithValue("@pass", pass.ToString());
                        commands.CommandType = CommandType.Text;
                        commands.ExecuteNonQuery();
                        
                    }
                };

                return true;
            }
            return false;
        }
    }



}
