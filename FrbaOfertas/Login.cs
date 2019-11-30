using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaOfertas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            RolCB.DropDownStyle = ComboBoxStyle.DropDownList;
            RolRegCB.DropDownStyle = ComboBoxStyle.DropDownList;
            cargarCB(RolCB);
            cargarCB(RolRegCB);
            RolRegCB.Items.Remove("Administrador General");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2019DataSet.Role' Puede moverla o quitarla según sea necesario.
            this.roleTableAdapter.Fill(this.gD2C2019DataSet.Role);

        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        int acumulador = 0;

        //CARGAR COMBO BOX CON ROLES
        public void cargarCB(ComboBox combo) {
            conexion.Open();
            SqlCommand comandoCB = new SqlCommand("SELECT Rol_Nombre FROM LOS_BORBOTONES.Role where Habilitado = 1", conexion);
            SqlDataReader dataCB = comandoCB.ExecuteReader();
            while (dataCB.Read())
            {
                combo.Items.Add(dataCB[0].ToString());
            }
            conexion.Close();
            combo.Items.Insert(0, "Elegir una opción...");
            combo.SelectedIndex = 0;
        }

        //LOGUEO DEL PROVEEDOR
        public void loguearProveedor(String usuario, string pass)
        {
            try
            {
                conexion.Open();
                SqlCommand comandoProv = new SqlCommand("select u.User_name, r.Rol_Nombre, u.Habilitado from LOS_BORBOTONES.Usuario u join LOS_BORBOTONES.Rol_Usuario ru on (u.User_name = ru.User_name) join LOS_BORBOTONES.Role r on(ru.Rol_Id = r.Rol_Id) where r.Rol_Nombre = 'Proveedor' and u.User_Name=@usuario and Password = HASHBYTES('SHA2_256', CAST( (cast(@pass as nvarchar(20))) AS varbinary(70)))", conexion);
                comandoProv.Parameters.AddWithValue("usuario", usuario);
                comandoProv.Parameters.AddWithValue("pass", pass);

                SqlDataAdapter data2 = new SqlDataAdapter(comandoProv);
                DataTable tabla2 = new DataTable();
                data2.Fill(tabla2);
                if (tabla2.Rows.Count == 1)
                {
                    int habilitado = Convert.ToInt32(tabla2.Rows[0][2]);
                    if (habilitado.Equals(1) && acumulador < 4)
                    {
                        this.Hide();
                        PantallaUsuarios.PantallaProveedor oferta = new PantallaUsuarios.PantallaProveedor(tabla2.Rows[0][0].ToString());  //tabla2.Rows[0][0].ToString()
                        oferta.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario se encuentra bloqueado...");

                    }
                }
                else
                {
                    MessageBox.Show("Los datos del proveedor ingresado son incorrectos...");
                    acumulador++;

                    if (acumulador.Equals(3))
                    {

                        MessageBox.Show("Se terminaron tus 3 intentos...");
                        bloquear(usuario);

                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally { conexion.Close(); }
        }


        //LOGUEO DEL ADMINISTRADOR
        public void loguearAdministrador(string usuario, string pass)
        {
            try
            {
                conexion.Open();
                SqlCommand comandoAdm = new SqlCommand("select u.User_name, r.Rol_Nombre from LOS_BORBOTONES.Usuario u join LOS_BORBOTONES.Rol_Usuario ru on (u.User_name = ru.User_name) join LOS_BORBOTONES.Role r on(ru.Rol_Id = r.Rol_Id) where r.Rol_Nombre = 'Administrador General' and u.User_Name=@usuario and Password = HASHBYTES('SHA2_256', CAST( cast(@pass as nvarchar(20)) AS varbinary(70)))", conexion);
                comandoAdm.Parameters.AddWithValue("usuario", usuario);
                comandoAdm.Parameters.AddWithValue("pass", pass);

                SqlDataAdapter data3 = new SqlDataAdapter(comandoAdm);
                DataTable tabla3 = new DataTable();
                data3.Fill(tabla3);
                if (tabla3.Rows.Count == 1)
                {
                    //int habilitado = Convert.ToInt32(tabla3.Rows[0][2]);
                    //if (habilitado.Equals(1) && acumulador < 4)
                    //{
                        this.Hide();
                        PantallaUsuarios.PantallaAdmin adm = new PantallaUsuarios.PantallaAdmin(tabla3.Rows[0][0].ToString());
                        adm.Show();
                    //}
                    //else
                    //{
                        //MessageBox.Show("El usuario se encuentra bloqueado...");

                    //}
                }
                else
                {
                    MessageBox.Show("Los datos del administrador ingresado son incorrectos...");
                    //acumulador++;

                    /*if (acumulador.Equals(3))
                    {

                        MessageBox.Show("Se terminaron tus 3 intentos...");
                        bloquear(usuario);

                    }*/
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally { conexion.Close(); }
        }

        //LOGUEO DEL CLIENTE
        public void logearCliente(String usuario, String pass)
        {
            try
            {
                conexion.Open();

                SqlCommand comandoCliente = new SqlCommand("select u.User_name, r.Rol_Nombre, u.Habilitado from LOS_BORBOTONES.Usuario u join LOS_BORBOTONES.Rol_Usuario ru on (u.User_name = ru.User_name) join LOS_BORBOTONES.Role r on(ru.Rol_Id = r.Rol_Id) where r.Rol_Nombre ='Cliente' and u.User_name=@usuario and Password = HASHBYTES('SHA2_256', CAST( (cast (@pass as nvarchar(20))) AS varbinary(70)))", conexion);
                comandoCliente.Parameters.AddWithValue("usuario", usuario);
                comandoCliente.Parameters.AddWithValue("pass", pass);
                SqlDataAdapter data = new SqlDataAdapter(comandoCliente);
                DataTable tabla = new DataTable();
                data.Fill(tabla);


                if (tabla.Rows.Count == 1)
                {
                    int habilitado = Convert.ToInt32(tabla.Rows[0][2]);
                    if (habilitado.Equals(1) && acumulador < 4)
                    {
                        this.Hide();
                        PantallaUsuarios.PantallaCliente cliente = new PantallaUsuarios.PantallaCliente(tabla.Rows[0][0].ToString());
                        cliente.Show();
                        acumulador = 0;
                    }
                    else { 
                        MessageBox.Show("El usuario se encuentra bloqueado...");
                        
                    }

                }
                else
                {
                    MessageBox.Show("Los datos del cliente ingresado son incorrectos...");
                    acumulador++;
                    
                    if(acumulador.Equals(3)){
                        
                        MessageBox.Show("Se terminaron tus 3 intentos...");
                        this.bloquear(usuario);
                        
                    }

                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
            finally { conexion.Close(); }
        }

        public void bloquear(String unUsuario)
        {
            
                SqlCommand comandoBloquear = new SqlCommand("UPDATE LOS_BORBOTONES.Usuario SET Habilitado = 0 WHERE User_name = @usuario", conexion);
                comandoBloquear.Parameters.AddWithValue("@usuario", unUsuario);
                int cant;
                cant = comandoBloquear.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Estas bloqueado, intente con otro usuario...");
                    acumulador = 0;
                }            
            UsuarioTB.Clear();
            PassTB.Clear();
        }
       

        

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            if(RolCB.SelectedIndex > 0){
                String unaSeleccion = RolCB.Text;

                if (unaSeleccion.Equals("Cliente"))
                {
                    logearCliente(this.UsuarioTB.Text, this.PassTB.Text);
                }
                else if (unaSeleccion.Equals("Proveedor"))
                {
                    loguearProveedor(this.UsuarioTB.Text, this.PassTB.Text);
                }
                else
                {
                    loguearAdministrador(this.UsuarioTB.Text, this.PassTB.Text);
                }
            }
            else
            {
                MessageBox.Show("Por favor elige un rol...");
            }
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            if (RolRegCB.SelectedIndex > 0)
            {
                String unaSeleccion = RolRegCB.Text;

                if (unaSeleccion.Equals("Cliente"))
                {
                    AbmCliente.NuevoCliente nuevo = new AbmCliente.NuevoCliente();
                    nuevo.ShowDialog();
                    
                }
                else 
                {
                    AbmProveedor.NuevoProveedor nuevo = new AbmProveedor.NuevoProveedor();
                    nuevo.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Para registrarte tienes que elegir un tipo...");
            }

        }

        
    }
}
