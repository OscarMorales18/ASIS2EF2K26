using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_PROVEEDORES.Formularios
{
    public partial class FrmProveedorNavegador : Form
    {
        public FrmProveedorNavegador()
        {
            InitializeComponent();
            //Dictionary<string, object> fuentes = new Dictionary<string, object>();
            //fuentes.Add("DsReportePaciente", datos.BancosMetObtenerTodos());
            //fuentes.Add("RpReportePacientes", datos.BancosMetObtenerTodos());
            BancosProveedores.NavegadorMetConfigurar("tbl_proveedor", 8000, 8015);
        }
    }
}
