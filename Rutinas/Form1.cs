using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rutinas
{
    public partial class Form1 : Form
    {
        #region Estructuras
        struct tipo_interprete
        {
            public string nombre;
            public string tipoGrupo;
        }
        struct tipo_cancion
        {
            public string titulo;
            public string interprete;
            public string genero;
        }
        #endregion

        #region Variables
        int topeInterprete = 10;
        tipo_interprete[] aInterpretes;
        int ultimoInterprete;

        int topeCanciones = 15;
        tipo_cancion[] aCanciones;
        int ultimoCancion;
        #endregion
        public Form1()
        {
            //falta que aparezca "Seleccione.." en el combobox interprete
            //falta ponerle foco al textbox nombre al iniciar el programa
            //falta crear funcion CantidadCancionesxInterprete(nombre de interprete):entero. No se para que sirve o donde se aplica
            //falta ver cuando el usuario quiere agregar un nuevo genero (tener en cuenta espacios y mayusculas)

            InitializeComponent();
            aInterpretes = new tipo_interprete[topeInterprete];
            ultimoInterprete = -1;

            aCanciones = new tipo_cancion[topeCanciones];
            ultimoCancion = -1;
            
            cbInterpretes.SelectedIndex = 0;
            cbGeneroInterpretes.SelectedIndex = 0;
            cbInterprete.Text = "Seleccione..";
        }
        
        #region Metodos - Paneles Interprete
        private bool ExisteInterprete(string nombreInterprete, out bool solista)
        {
            int i = 0;
            bool cargado = false;
            solista = true;

            //recorre el arreglo
            while ((i <= ultimoInterprete) && (!cargado) && (aInterpretes[i].nombre.CompareTo(nombreInterprete) < 1))
            {
                //si encuentra ya cargado el artista
                if (aInterpretes[i].nombre.CompareTo(nombreInterprete) == 0)
                {
                    //determina si es solista o no, sirve para luego poner si es solista o grupo en el message
                    if (aInterpretes[i].tipoGrupo.CompareTo("Solista") != 0)
                    {
                        solista = false;
                    }
                    return cargado = true; //si es verdadero es solita
                }
                else
                {
                    i++;
                }
            }
            return cargado; //es falso, es grupo
        }
        private void RedimensionarInterpretes(ref tipo_interprete[] arreglo, int ultimo, ref int tope, int cantidad)
        {
            tipo_interprete[] aInterpretesAux;
            tope += cantidad; //aumento el tope en 3
            aInterpretesAux = new tipo_interprete[tope];

            //paso todos los elementos a un auxiliar
            for (int j = 0; j <= ultimoInterprete; j++)
            {
                aInterpretesAux[j].nombre = arreglo[j].nombre;
                aInterpretesAux[j].tipoGrupo = arreglo[j].tipoGrupo;
            }
            arreglo = aInterpretesAux;
            MessageBox.Show("Puede seguir añadiendo interpretes","Añadir",MessageBoxButtons.OK,MessageBoxIcon.Information);
            tNombre.Focus();
        }
        private void InsertarInterpreteOrdenado(string interprete)
        {
            int i = ultimoInterprete;
            //busca el lugar del nuevo elemento
            while ((i >= 0) && (aInterpretes[i].nombre.CompareTo(interprete) > 0))
            {
                aInterpretes[i + 1].nombre = aInterpretes[i].nombre;
                aInterpretes[i + 1].tipoGrupo = aInterpretes[i].tipoGrupo;
                i--;
            }
            //agrego el nuevo elemento en su lugar correspondiente
            aInterpretes[i + 1].nombre = interprete;
            //se fija si es solista o grupo
            aInterpretes[i + 1].tipoGrupo = (rbSolista.Checked) ? rbSolista.Text : rbGrupo.Text;
            ++ultimoInterprete;
            MessageBox.Show("Se ha agregado exitosamente", "Guardar",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void ListarInterprete(bool solista, bool grupo)
        {
            int cant = 0;
            lbInterpretes.Items.Clear();
            lCantidadI.Text = "";
            if (solista && grupo) //si esta check solista y grupo
            {
                for (int i = 0; i <= ultimoInterprete; i++)
                {
                    lbInterpretes.Items.Add(aInterpretes[i].nombre);
                }
                lCantidadI.Text = $"Cantidad: {ultimoInterprete + 1}";
            }
            else if (solista) //si esta check solista
            {
                for (int i = 0; i <= ultimoInterprete; i++)
                {
                    if (aInterpretes[i].tipoGrupo == "Solista")
                    {
                        lbInterpretes.Items.Add(aInterpretes[i].nombre);
                        cant++;
                    }
                    lCantidadI.Text = $"Cantidad: {cant}";
                }
            }
            else if (grupo) //si esta check grupo
            {
                for (int i = 0; i <= ultimoInterprete; i++)
                {
                    if (aInterpretes[i].tipoGrupo == "Grupo")
                    {
                        lbInterpretes.Items.Add(aInterpretes[i].nombre);
                        cant++;
                    }
                    lCantidadI.Text = $"Cantidad: {cant}";
                }
            }
            else //si no hay nada chequeado
            {
                lbInterpretes.Items.Clear();
                lCantidadI.Text = "Cantidad: 0";
            }
        }      
        private void ActualizarDatosInterpretes()
        {
            tNombre.Clear();
            tNombre.Focus();
            rbSolista.Checked = true;
            ListarInterprete(checkSolista.Checked, checkGrupo.Checked);
            lTotalInterprete.Text = $"Cantidad total de interpretes: {ultimoInterprete+1}";

            cbInterprete.Items.Clear();
            cbInterpretes.Items.Clear();
            cbInterpretes.Items.Add("TODOS");
            cbInterpretes.SelectedIndex = 0;
            for (int k = 0; k <= ultimoInterprete; k++)
            {
                cbInterprete.Items.Add(aInterpretes[k].nombre);
                cbInterpretes.Items.Add(aInterpretes[k].nombre);
            }
        }
        private void EliminarInterpreteOrdenado(string artista)
        {
            for (int i = 0; i <= ultimoInterprete; i++) //Recorro el arreglo
            {
                if (aInterpretes[i].nombre.CompareTo(artista) == 0) //Si se encuentra el artista que se buscaba 
                {
                    for (int j = i; j < ultimoInterprete; j++) //Desde la posicion hasta el final - 1 desplazamos hacia atras todas los artistas
                    {
                        aInterpretes[j].nombre = aInterpretes[j + 1].nombre; //Vamos desplazando los elementos a un indice anterior
                        aInterpretes[j].tipoGrupo = aInterpretes[j + 1].tipoGrupo;
                    }
                    //elimino el ultimo elemento
                    aInterpretes[ultimoInterprete].nombre = null; 
                    aInterpretes[ultimoInterprete].tipoGrupo = null;
                    MessageBox.Show("Se ha eliminado correctamente", "Eliminar",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    --ultimoInterprete;
                    ActualizarDatosInterpretes();
                    bGuardarI.Enabled = true;
                    break;
                }
            }
        }
        #endregion
    
        #region Metodos - Paneles canciones
        private void RedimensionarCanciones(ref tipo_cancion[] arreglo, int ultimo, ref int tope, int cantidad)
        {
            tipo_cancion[] aCancionesAux;

            tope += cantidad;
            aCancionesAux = new tipo_cancion[tope];

            for (int j = 0; j <= ultimo; j++)
            {
                aCancionesAux[j].titulo = arreglo[j].titulo;
                aCancionesAux[j].interprete = arreglo[j].interprete;
                aCancionesAux[j].genero = arreglo[j].genero;
            }
            arreglo = aCancionesAux;
        }
        private bool ExisteCancion(string nombreCancion, out string interprete,out string genero)
        {
            int i = 0;
            bool cargado = false;
            interprete = "";
            genero = "";

            while ((i <= ultimoCancion) && (!cargado) && (aCanciones[i].titulo.CompareTo(nombreCancion) < 1))
            {
                if (aCanciones[i].titulo.CompareTo(nombreCancion) == 0)
                {
                    interprete = aCanciones[i].interprete;
                    genero = aCanciones[i].genero;
                    return cargado = true;
                }
                else
                {
                    i++;
                }
            }
            return cargado;
        }
        private void InsertarCancionOrdenada (string cancion)
        {
            int i = ultimoCancion;

            while ((i >= 0) && (aCanciones[i].titulo.CompareTo(cancion) > 0))
            {
                aCanciones[i + 1].titulo = aCanciones[i].titulo;
                aCanciones[i + 1].interprete = aCanciones[i].interprete;
                aCanciones[i + 1].genero = aCanciones[i].genero;
                i--;
            }

            aCanciones[i + 1].titulo = cancion;
            aCanciones[i + 1].interprete = cbInterprete.SelectedItem.ToString();
            aCanciones[i + 1].genero = cbGeneroInterprete.SelectedItem.ToString();
            ++ultimoCancion;
            MessageBox.Show("Se ha agregado exitosamente", "Atencion", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void ListarCanciones(string artista, string genero)
        {
            int cant = 0;
            lbCanciones.Items.Clear();
            lCantidadC.Text = "";
            
            //si esta seleccionado todos en interprete y genero
            if ((artista.CompareTo("TODOS") == 0) && (genero.CompareTo("TODOS")==0))
            {
                for (int i = 0; i <= ultimoCancion; i++)
                {
                    lbCanciones.Items.Add(aCanciones[i].titulo);
                    cant++;
                }
                lCantidadC.Text = $"Cantidad: {ultimoCancion+1}";
            }
            else if (artista == "TODOS") //si esta seleccionado todos en interprete
            {
                for (int i = 0; i <= ultimoCancion; i++)
                {
                    if (genero == aCanciones[i].genero) //si coincide con el genero seleccionado en el combo
                    {
                        lbCanciones.Items.Add(aCanciones[i].titulo);
                        cant++;
                    }
                }
                lCantidadC.Text = $"Cantidad: {cant}";
            }
            else if (genero == "TODOS") //si esta seleccionado todos en genero
            {
                for (int i = 0; i <= ultimoCancion; i++)
                {
                    if (artista == aCanciones[i].interprete) //si coincide con el interprete seleccionado en el combo
                    {
                        lbCanciones.Items.Add(aCanciones[i].titulo);
                        cant++;
                    }
                }
                lCantidadC.Text = $"Cantidad: {cant}";
            }
            else //en el caso que no este seleccionado "todos" en ningun combo
            {
                for (int i = 0; i <= ultimoCancion; i++)
                {
                    if (artista == aCanciones[i].interprete)
                    {
                        if (genero == aCanciones[i].genero)
                        {
                            lbCanciones.Items.Add(aCanciones[i].titulo);
                            cant++;
                        }
                    }
                }
                lCantidadC.Text = $"Cantidad: {cant}";
            }
        }
        private void EliminarCancionOrdenada (string cancion)
        {
            for (int i = 0; i <= ultimoCancion; i++) //Recorro el arreglo
            {
                if (aCanciones[i].titulo.CompareTo(cancion) == 0) //Si se encuentra la cancion que se buscaba 
                {
                    for (int j = i; j < ultimoCancion; j++) //Desde la posicion hasta el final - 1 desplazamos hacia atras todas las canciones
                    {
                        aCanciones[j].titulo = aCanciones[j + 1].titulo; //Vamos desplazando los elementos a un indice anterior
                        aCanciones[j].interprete = aCanciones[j + 1].interprete;
                        aCanciones[j].genero = aCanciones[j + 1].genero;
                    }
                    aCanciones[ultimoCancion].titulo = null;
                    aCanciones[ultimoCancion].interprete = null;
                    aCanciones[ultimoCancion].genero = null;
                    MessageBox.Show("Se ha eliminado correctamente", "Eliminar",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    --ultimoCancion;
                    ActualizarDatosInterpretes();
                    break;
                }
            }
        }
        private void ActualizarDatosCanciones()
        {
            tTitulo.Clear();
            tTitulo.Focus();
            lbCanciones.Items.Clear();
            cbInterprete.SelectedIndex = -1;
            cbGeneroInterprete.SelectedIndex = -1;
            cbGeneroInterprete.Text = "Seleccione..";
            string a="";
            ListarCanciones(cbInterpretes.SelectedItem.ToString(),a);
            lTotalCanciones.Text = $"Cantidad total de canciones: {ultimoCancion+1}";
        }
        #endregion

        #region Eventos de botones (interpretes)
        private void bGuardarI_Click(object sender, EventArgs e)
        {
            string nombre = tNombre.Text.Trim().ToLower();
            bool solista;
            DialogResult respuesta;

            if (ultimoInterprete + 1 == topeInterprete) //Si no hay lugar en el arreglo
            {
                respuesta = MessageBox.Show("La lista esta llena.¿Desea agregar mas interpretes?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Si el usuario responde que desea agregar interpretes
                if (respuesta == DialogResult.Yes)
                {
                    RedimensionarInterpretes(ref aInterpretes, ultimoInterprete, ref topeInterprete, 4);
                    tNombre.Focus();
                }
                else //Si el usuario responde que no quiere agregar mas interpretes
                {
                    MessageBox.Show("No se pueden añadir mas interpretes", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tNombre.Clear();
                    bGuardarI.Enabled = false;
                }
            }
            else if (nombre == "") //si el titulo esta incompleto
            {
                MessageBox.Show("El titulo está incompleto, por favor reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tNombre.Focus();
            }
            else if (ExisteInterprete(nombre, out solista)) //si esta el interprete ya cargado
            {
                if (solista)
                {
                    MessageBox.Show("El solista que desea ingresar ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El grupo que desea ingresar ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ActualizarDatosInterpretes();
                tNombre.Focus();
            }
            else //si pasa todos los chequeos
            {
                InsertarInterpreteOrdenado(nombre);
                ListarInterprete(checkSolista.Checked, checkGrupo.Checked);
                ActualizarDatosInterpretes();
                tNombre.Focus();
            }
        }
        private void bEliminarI_Click(object sender, EventArgs e)
        {
            int cant = lbInterpretes.Items.Count;
            string interprete;
            bool baja = true;
            string canciones = "";

            if (lbInterpretes.SelectedIndex != -1) //si tiene un elemento seleccionado
            {
                interprete = lbInterpretes.SelectedItem.ToString();
                for (int j = 0; j <= ultimoCancion; j++)
                {
                    if (aCanciones[j].interprete.CompareTo(interprete) == 0)
                    {
                        baja = false;
                        canciones += $" \"{aCanciones[j].titulo}\" \n";
                    }
                }

                if (baja == false)
                {
                    MessageBox.Show($"No se puede eliminar este interprete porque tiene las siguientes canciones: {canciones}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EliminarInterpreteOrdenado(interprete);
                    ActualizarDatosInterpretes();
                }
            }
            else if (ultimoInterprete == -1)
            {
                MessageBox.Show("Todavia no hay interpretes cargados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun interprete, reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Eventos de botones (canciones)
        private void bGuardarC_Click(object sender, EventArgs e)
        {
            string titulo = tTitulo.Text.Trim().ToLower();
            string interprete, genero;

            if (ultimoCancion + 1 == topeCanciones) //Si no hay lugar en el arreglo
            {
                RedimensionarCanciones(ref aCanciones, ultimoCancion, ref topeCanciones, 3);
                MessageBox.Show("Se han agregado tres lugares para añadir interpretes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (titulo == "") //si el titulo esta incompleto
            {
                MessageBox.Show("El titulo está incompleto, por favor reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tNombre.Focus();
            }
            else if (cbInterprete.SelectedIndex == -1)
            {
                MessageBox.Show("El interprete no está seleccionado, por favor reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbInterprete.Focus();
            }
            else if (cbGeneroInterprete.SelectedIndex == -1)
            {
                MessageBox.Show("El género no está seleccionado, por favor reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbGeneroInterprete.Focus();
            }
            else if (ExisteCancion(titulo, out interprete, out genero))
            {
                MessageBox.Show($"La cancion \"{titulo}\" ya esta cargada, su interprete es \"{interprete}\" y su genero es \"{genero}\"");
            }
            else
            {
                InsertarCancionOrdenada(titulo);
                ActualizarDatosCanciones();
                ListarCanciones(cbInterpretes.SelectedItem.ToString(), cbGeneroInterpretes.SelectedItem.ToString());
            }
        }
        private void bEliminarC_Click(object sender, EventArgs e)
        {
            int cant = lbInterpretes.Items.Count;
            string cancion;

            if (lbCanciones.SelectedIndex != -1) //si tiene un elemento seleccionado
            {
                cancion = lbCanciones.SelectedItem.ToString();
                EliminarCancionOrdenada(cancion);
                ActualizarDatosCanciones();
                ListarCanciones(cbInterpretes.SelectedItem.ToString(), cbGeneroInterpretes.SelectedItem.ToString());
            }
            else if (ultimoCancion == -1)
            {
                MessageBox.Show("Todavia no hay canciones cargadas", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna cancion, reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Cerrar Aplicacion
        private void bCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Está seguro que desea cerrar la aplicacion?", "Cerrar",MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("¿Está seguro que desea cerrar la aplicacion?", "Cerrar", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    Close();
                }
            }
        }
        #endregion

        #region Cambios en CheckBox (interpretes)
        private void checkSolista_CheckedChanged(object sender, EventArgs e)
        {
            ListarInterprete(checkSolista.Checked, checkGrupo.Checked);
        }
        private void checkGrupo_CheckedChanged(object sender, EventArgs e)
        {
            ListarInterprete(checkSolista.Checked, checkGrupo.Checked);
        }
        #endregion

        #region Cambios en ComboBox (canciones)
        private void cbInterpretes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDatosCanciones();
            if (ultimoCancion != -1)
            {
                ListarCanciones(cbInterpretes.SelectedItem.ToString(), cbGeneroInterpretes.SelectedItem.ToString());
            }
        }
        private void cbGeneroInterpretes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDatosCanciones();
            if (ultimoCancion != -1)
            {
                ListarCanciones(cbInterpretes.SelectedItem.ToString(), cbGeneroInterpretes.SelectedItem.ToString());
            }
        }
        #endregion
    }
}