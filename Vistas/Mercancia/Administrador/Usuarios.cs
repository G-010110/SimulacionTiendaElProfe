using SimulacionTiendaElProfe.Conexiones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionTiendaElProfe.Vistas.Administrador
{
    public partial class Usuarios : UserControl
    {
        private int indexUsuario;
        private string nombre, ap, am, edad, sexo,alias,clave,nombreTurno,finicio,ffin,query;
        private Conector conectar;
        private int idUs;

        private List<int> turn;
        private int indexTurno;
        public Usuarios()
        {
            InitializeComponent();
            turn = new List<int>();
            conectar = new ConectorSQLite();
            mostrarPersonas();
            mostrarTurnos();
            cargarListaTurno();
        }

        private void bAgregarTurno_Click(object sender, EventArgs e)
        {
            cargarEntradas();
            crearTurno();
            cargarListaTurno();
        }

        //Retorna el tipo de usuario
        private void comboTusuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboTusuario.SelectedItem.ToString();
            switch(n)
            {
                case "root":
                    indexUsuario = 1;
                    break;
                case "user":
                    indexUsuario = 2;
                    break;
                case "visitor":
                    indexUsuario = 3;
                    break;
            }
        }

        private void comboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexTurno = comboTurno.SelectedIndex;
        }

        private void comboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sexo = comboSexo.SelectedItem.ToString();
            }
            catch(NullReferenceException ee) 
            {
            
            }
                
        }

        private void bAgregarU_Click(object sender, EventArgs e)
        {
            //Capturar datos
            cargarEntradas();
            if(!ExisteUsuarioRoot())
            {
                //Crear y agregar
                crearUsuario();
                crearPersona();
                //Mostrar
                mostrarPersonas();
                
            } else
            {
                MessageBox.Show("Solo puede haber un usuario root");
            }
            //Borrar entradas
            descargarEntradas();
        }

        public void crearUsuario()
        {
            using (DbConnection conexion = conectar.crearConexion())
            {
                conexion.Open();
                query = "insert into Usuarios (Alias,Clave,TipoUsuario_idTipoUsuario) VALUES (@alia,@pass,@usuario);";
                using (DbCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = query;

                    comando.Parameters.AddRange(new DbParameter[] {
                        new SQLiteParameter("@alia",alias),
                        new SQLiteParameter("@pass",clave),
                        new SQLiteParameter("@usuario",indexUsuario)
                    });
                    
                    comando.ExecuteNonQuery();
                    ///////
                    comando.Parameters.Clear();
                    comando.CommandText = "SELECT idUsuarios from Usuarios WHERE Alias=@alias;";
                    comando.Parameters.AddRange(new DbParameter[] {
                        new SQLiteParameter("@alias",alias),
                    });
                    using (DbDataReader leer = comando.ExecuteReader())
                    {
                        if (leer != null && leer.Read())
                        {
                            idUs = int.Parse(leer["idUsuarios"].ToString());
                        }
                    }
                }
            }
        }
        public void crearPersona()
        {
            using (DbConnection conexion = conectar.crearConexion())
            {
                conexion.Open();
                query = "insert into Personas (Nombre,AP,AM,Edad,Sexo,Usuarios_idUsuarios,Turno_idTurno) VALUES (@nombre,@ap,@am,@edad,@sexo,@usuarioid,@idturno);";
                using (DbCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = query;

                    comando.Parameters.AddRange(new DbParameter[] {
                        new SQLiteParameter("@nombre",nombre),
                        new SQLiteParameter("@ap",ap),
                        new SQLiteParameter("@am",am),
                        new SQLiteParameter("@edad",edad),
                        new SQLiteParameter("@sexo",sexo),
                        new SQLiteParameter("@usuarioid",idUs),
                        new SQLiteParameter("@idturno",turn[indexTurno])
                    });

                    comando.ExecuteNonQuery();
                 
                }
            }
        }

        public void mostrarPersonas()
        {
            using (DbConnection conexion = conectar.crearConexion())
            {
                conexion.Open();
                query = "select * from Personas;";
                using (DbCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = query;

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter((SQLiteCommand)comando);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataPersonal.DataSource = dt;
                }
            }
        }
        public void cargarEntradas()
        {
            nombre=tNombre.Text;
            ap=tAP.Text;
            am = tAM.Text;
            edad = tEdad.Text;
            alias=tAlias.Text;
            clave=tClave.Text;
            finicio = tFinicio.Text;
            ffin=tFinicio.Text;
            nombreTurno=tNombreTurno.Text;
        }
        public void descargarEntradas()
        {
            tNombre.Text="";
            tAP.Text="";
            tAM.Text="";
            tEdad.Text="";
            tAlias.Text="";
            tClave.Text="";
            try
            {
                //comboSexo.SelectedItem = null;
                //comboTusuario.SelectedIndex = -1;
                //comboTurno.SelectedIndex = -1;
            } catch(Exception ex)
            {

            }
            
        }

        public void mostrarTurnos()
        {
            using (DbConnection conexion = conectar.crearConexion())
            {
                conexion.Open();
                query = "select * from Turno;";
                using (DbCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = query;

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter((SQLiteCommand)comando);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataTurnos.DataSource = dt;
                }
            }
        }
        public void crearTurno()
        {
            using (DbConnection conexion = conectar.crearConexion())
            {
                conexion.Open();
                query = "insert into Turno (Nombre,Fecha_Inicio,Fecha_Fin) VALUES (@nombre,@fi,@ff);";
                using (DbCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = query;

                    comando.Parameters.AddRange(new DbParameter[] {
                        new SQLiteParameter("@nombre",nombreTurno),
                        new SQLiteParameter("@fi",finicio),
                        new SQLiteParameter("@ff",ffin)
                    });

                    comando.ExecuteNonQuery();
                }
            }
        }
        public void cargarListaTurno()
        {
            comboTurno.Items.Clear();
            using (DbConnection conexion = conectar.crearConexion())
            {
                conexion.Open();
                query = "SELECT idTurno,Nombre FROM Turno;";
                //SQLiteCommand comando = new SQLiteCommand(query,(SQliteConnection)conexion);
                DbCommand comando = conexion.CreateCommand();
                comando.CommandText = query;

                using (DbDataReader leer = comando.ExecuteReader())
                {
                    while (leer.Read())
                    {
                        comboTurno.Items.Add($"{leer["Nombre"]}");
                        turn.Add(int.Parse($"{leer["idTurno"]}"));
                    }
                }
            }
        }

        public bool ExisteUsuarioRoot()
        {
            using (DbConnection conexion = conectar.crearConexion())
            {
                conexion.Open();
                query = "SELECT * FROM Usuarios INNER JOIN TipoUsuario ON Usuarios.TipoUsuario_idTipoUsuario = TipoUsuario.idTipoUsuario WHERE TipoUsuario.Nombre = @nombre;";
                using (DbCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = query;
                    comando.Parameters.Add(new SQLiteParameter("@nombre", "root"));
                    object res = comando.ExecuteScalar();
                    if (res == null || res == DBNull.Value) return false;
                    int count;
                    try { count = Convert.ToInt32(res); }
                    catch { return false; }
                    return count > 0;
                }
            }
        }
    }
}
