﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Dominio; 

namespace Presentacion
{
    public partial class Articulos : Form
    {
        private List<Dominio.Articulos> listArticulos;
        public Articulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e) ///Carga la imagen
        {
            try
            {
                pbArticulo.Load(dgvArticulos.CurrentRow.Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                //MessageBox.Show("imagen inválida o no disponible", "error al cargar la URL",MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbArticulo.Load("https://alasmutual.com/nueva/wp-content/themes/consultix/images/no-image-found-360x250.png"); 
                 
            }
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar Agregar = new frmAgregar();
            Agregar.ShowDialog();
            cargarArticulos();
        }

        public void cargarArticulos()
        {
            ArticuloNegocio negocioArticulos = new ArticuloNegocio();

            try
            {
                listArticulos = negocioArticulos.listar();

                dgvArticulos.DataSource = listArticulos;

                dgvArticulos.Columns["imagenURL"].Visible = false;

                dgvArticulos.Columns["ID"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void cargarArticulos( string filtro)
        {
            List<Dominio.Articulos> articulosFiltrados = new List<Dominio.Articulos>(); 

            try
            {
                foreach (Dominio.Articulos item in listArticulos) { 
                
                    if(chequearFiltros(item, filtro)){   

                        articulosFiltrados.Add(item); 
                    }
                }

                dgvArticulos.DataSource = articulosFiltrados;  
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        } 

        public bool chequearFiltros(Dominio.Articulos item, string filtro)
        {
            if (item.Nombre.ToLower().Contains(filtro.ToLower()))
            {
                return true; 
            }

            if (item.Marca.Descripcion.ToLower().Contains(filtro.ToLower()))
            {
                return true;
            }

            if (item.Categoria.Descripcion.ToLower().Contains(filtro.ToLower()))
            {
                return true;
            }

            return false; 
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Detalle detalle = new Detalle(obtenerArticuloDataGrid()); 
            detalle.ShowDialog(); 
        } 

        public Dominio.Articulos obtenerArticuloDataGrid()
        {
            Dominio.Articulos articulo = new Dominio.Articulos();

            articulo =(Dominio.Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            return articulo;  

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarArticulos(txtBuscar.Text); 
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "")
            {
                dgvArticulos.DataSource = listArticulos;  
            }     
        }

      

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            DialogResult respuesta=MessageBox.Show("¿Está seguro que desea eliminar el articulo "+ dgvArticulos.CurrentRow.Cells[2].Value.ToString()+" ?", "Elimminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta==DialogResult.Yes)
            {
                try
                {
                    articuloNegocio.EliminarArticulo(dgvArticulos.CurrentRow.Cells[0].Value.ToString());
                    cargarArticulos();
                    MessageBox.Show("Se ha eliminado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                }
               
            }
        }

        private void bntModificar_Click(object sender, EventArgs e)
        {
            Dominio.Articulos articulo = new Dominio.Articulos();
            articulo = (Dominio.Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            frmModificar frmModificar = new frmModificar(articulo);
            frmModificar.ShowDialog();
            cargarArticulos();
        }
    }
      
}
