using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_de_eduardo
{
    public partial class Ventas : Form
    {
        static Queue<int> pastelitos = new Queue<int>();                // 👉 Cola para Pastelitos
        static Queue<int> chocolates = new Queue<int>();               // 👉 Cola para Chocolates
        static Queue<int> doritos = new Queue<int>();                 // 👉 Cola para Doritos
        static Queue<int> mym = new Queue<int>();                    // 👉 Cola para Mym
        static Queue<int> galletaOreo = new Queue<int>();           // 👉 Cola para Galleta Oreo 
        static Queue<int> mani = new Queue<int>();                 // 👉 Cola para Mani 
        static Queue<int> papasLays = new Queue<int>();           // 👉 Cola para Papas Lays 
        static Queue<int> meneitos = new Queue<int>();           // 👉 Cola para Meneitos 
        static Queue<int> almendras = new Queue<int>();         // 👉 Cola para Almendras 
        static Queue<int> nachos = new Queue<int>();           // 👉 Cola para Nachos 
        static Queue<int> palitosHorneados = new Queue<int>();// 👉 Cola para Palitos Horneados
        static Queue<int> nueces = new Queue<int>();         // 👉 Cola para Nueces 
        static Queue<int> snackKeto = new Queue<int>();     // 👉 Cola para Snack Keto
        static Queue<int> wafersFresa = new Queue<int>();  // 👉 Cola para Wafers de Fresa 
        static Queue<int> empanadas = new Queue<int>();   // 👉 Cola para Empanadas 

        static float[,] matriz = new float[5, 3];                // Matriz para precios de productos
        int cantidad = 0;

        public Ventas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float precio = 0;                       // Variable para almacenar el precio del producto seleccionado
            float moneda = 0;                       // Variable para almacenar el monto ingresado por el usuario
            string codigo = tcodigo.Text;           // Variable para almacenar el código del producto ingresado por el usuario

            // Selección de las monedas
            if (r100.Checked)
                moneda = 100;
            else if (r500.Checked)
                moneda = 500;
            else if (r1000.Checked)
                moneda = 1000;
            else if (r2000.Checked)
                moneda = 2000;
            else if (r5000.Checked)
                moneda = 5000;
            else if (r10000.Checked)
                moneda = 10000;
            else
            {
                MessageBox.Show("Por favor seleccione una moneda."); // Si no se selecciona una moneda, muestra un mensaje de error
                return;
            }

            switch (codigo)                                  // Verifica el código ingresado por el usuario
            {
                case "00":                                   // Código para comprar chocolates
                    precio = matriz[0, 0];                   // Obtiene el precio del chocolate de la matriz

                    if (chocolates.Count == 0)              // Verifica si hay chocolates disponibles
                    {
                        MessageBox.Show("No hay chocolates disponibles.");   // Si no hay chocolates, muestra un mensaje de error
                        lchocolates.Text = "Está vacío";                     // Actualiza el texto del label de chocolates
                        return;
                    }

                    if (moneda < precio)                             // Verifica si el monto ingresado es menor que el precio del chocolate
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    chocolates.Dequeue();                                // Elimina un chocolate de la cola
                    lchocolates.Text = chocolates.Count.ToString();      // Actualiza el texto del label de chocolates
                    float vueltoChocolate = moneda - precio;             // Calcula el vuelto
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoChocolate}");
                    break;

                case "01":
                    precio = matriz[0, 1];

                    if (pastelitos.Count == 0)
                    {
                        MessageBox.Show("No hay pastelitos disponibles.");
                        lpastelitos.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    pastelitos.Dequeue();
                    lpastelitos.Text = pastelitos.Count.ToString();
                    float vueltoPastelito = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoPastelito}");
                    break;

                default:
                    MessageBox.Show("Código inválido. Use 00 para chocolates o 01 para pastelitos.");
                    break;
                case "02":
                    precio = matriz[0, 2];

                    if (doritos.Count == 0)
                    {
                        MessageBox.Show("No hay Doritos disponibles.");
                        ldoritos.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    doritos.Dequeue();
                    ldoritos.Text = doritos.Count.ToString();
                    float vueltoDoritos = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoDoritos}");
                    break;
                case "03":
                    precio = matriz[1, 0];

                    if (mym.Count == 0)
                    {
                        MessageBox.Show("No hay Mym disponibles.");
                        lmym.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    mym.Dequeue();
                    lmym.Text = mym.Count.ToString();
                    float vueltoMym = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoMym}");
                    break;
                case "04":
                    precio = matriz[1, 1];

                    if (galletaOreo.Count == 0)
                    {
                        MessageBox.Show("No hay Galleta Oreo disponibles.");
                        lgalletaOreo.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    galletaOreo.Dequeue();
                    lgalletaOreo.Text = galletaOreo.Count.ToString();
                    float vueltoGalleta = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoGalleta}");
                    break;
                case "05":
                    precio = matriz[1, 2];

                    if (mani.Count == 0)
                    {
                        MessageBox.Show("No hay Maní disponibles.");
                        lmani.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    mani.Dequeue();
                    lmani.Text = mani.Count.ToString();
                    float vueltoMani = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoMani}");
                    break;
                case "06":
                    precio = matriz[2, 0];

                    if (papasLays.Count == 0)
                    {
                        MessageBox.Show("No hay Papas Lays disponibles.");
                        lpapasLays.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    papasLays.Dequeue();
                    lpapasLays.Text = papasLays.Count.ToString();
                    float vueltoLays = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoLays}");
                    break;
                case "07":
                    precio = matriz[2, 1];

                    if (meneitos.Count == 0)
                    {
                        MessageBox.Show("No hay Meneítos disponibles.");
                        lmeneitos.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    meneitos.Dequeue();
                    lmeneitos.Text = meneitos.Count.ToString();
                    float vueltoMeneitos = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoMeneitos}");
                    break;
                case "08":
                    precio = matriz[2, 2];

                    if (almendras.Count == 0)
                    {
                        MessageBox.Show("No hay Almendras disponibles.");
                        lalmendras.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    almendras.Dequeue();
                    lalmendras.Text = almendras.Count.ToString();
                    float vueltoAlmendras = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoAlmendras}");
                    break;
                case "09":
                    precio = matriz[3, 0];

                    if (nachos.Count == 0)
                    {
                        MessageBox.Show("No hay Nachos disponibles.");
                        lnachos.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    nachos.Dequeue();
                    lnachos.Text = nachos.Count.ToString();
                    float vueltoNachos = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoNachos}");
                    break;
                case "10":
                    precio = matriz[3, 1];

                    if (palitosHorneados.Count == 0)
                    {
                        MessageBox.Show("No hay Palitos Horneados disponibles.");
                        lpalitos.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    palitosHorneados.Dequeue();
                    lpalitos.Text = palitosHorneados.Count.ToString();
                    float vueltoPalitos = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoPalitos}");
                    break;
                case "11":
                    precio = matriz[3, 2];

                    if (nueces.Count == 0)
                    {
                        MessageBox.Show("No hay Nueces disponibles.");
                        lnueces.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    nueces.Dequeue();
                    lnueces.Text = nueces.Count.ToString();
                    float vueltoNueces = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoNueces}");
                    break;
                case "12":
                    precio = matriz[4, 0];

                    if (snackKeto.Count == 0)
                    {
                        MessageBox.Show("No hay Snack Keto disponibles.");
                        lsnackKeto.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    snackKeto.Dequeue();
                    lsnackKeto.Text = snackKeto.Count.ToString();
                    float vueltoKeto = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoKeto}");
                    break;
                case "13":
                    precio = matriz[4, 1];

                    if (wafersFresa.Count == 0)
                    {
                        MessageBox.Show("No hay Wafers sabor fresa disponibles.");
                        lwafers.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    wafersFresa.Dequeue();
                    lwafers.Text = wafersFresa.Count.ToString();
                    float vueltoWafers = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoWafers}");
                    break;
                case "14":
                    precio = matriz[4, 2];

                    if (empanadas.Count == 0)
                    {
                        MessageBox.Show("No hay empanadas disponibles.");
                        lempanadas.Text = "Está vacío";
                        return;
                    }

                    if (moneda < precio)
                    {
                        MessageBox.Show($"Monto insuficiente. El precio es de: ₡{precio} colones y estas ingresando un monto de: ₡{moneda} colones");
                        return;
                    }

                    empanadas.Dequeue();
                    lempanadas.Text = empanadas.Count.ToString();
                    float vueltoEmpanadas = moneda - precio;
                    MessageBox.Show($"¡Gracias por su compra! Su vuelto es de: ₡{vueltoEmpanadas}");
                    break;

            }
        }
        private void tcodigo_TextChanged(object sender, EventArgs e) // Botón para comprar productos
        {
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            matriz[0, 0] = 950;               // Precio del chocolate
            matriz[0, 1] = 850;              // Precio del pastelito
            matriz[0, 2] = 1000;            // Precio de los Doritos
            matriz[1, 0] = 2000;           // Precio del Mym
            matriz[1, 1] = 2685;          // Precio Galleta Oreo
            matriz[1, 2] = 890;          // Precio Maní
            matriz[2, 0] = 3005;        // Papas Lays
            matriz[2, 1] = 2050;       // Precio Meneítos
            matriz[2, 2] = 3750;      // Precio Almendras
            matriz[3, 0] = 1499;     // Nachos
            matriz[3, 1] = 1890;    // Palitos Horneados
            matriz[3, 2] = 8690;   // Precio de Nueces
            matriz[4, 0] = 3300;  // Precio Snack Keto
            matriz[4, 1] = 980;  // Precio de Wafers sabor fresa
            matriz[4, 2] = 2100;// Empanadas
        }

        private void button2_Click(object sender, EventArgs e)   // boton de agregar chocolates
        {
            chocolates.Enqueue(cantidad);                           // Agrega un chocolate a la cola
            cantidad++;                                             // Incrementa la cantidad para el siguiente producto
            lchocolates.Text = chocolates.Count.ToString();         // Actualiza el texto del label de chocolates con la cantidad actual
        }

        private void button3_Click(object sender, EventArgs e)   // boton de agregar pastelitos
        {
            pastelitos.Enqueue(cantidad);
            cantidad++;
            lpastelitos.Text = pastelitos.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)  // boton de agregar Doritos
        {
            doritos.Enqueue(cantidad);
            cantidad++;
            ldoritos.Text = doritos.Count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)  // boton de agregar Mym
        {
            mym.Enqueue(cantidad);
            cantidad++;
            lmym.Text = mym.Count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)  // boton de agregar Galleta Oreo
        {
            galletaOreo.Enqueue(cantidad);
            cantidad++;
            lgalletaOreo.Text = galletaOreo.Count.ToString();
        }

        private void button7_Click(object sender, EventArgs e)  // boton de agregar Mani
        {
            mani.Enqueue(cantidad);
            cantidad++;
            lmani.Text = mani.Count.ToString();
        }

        private void button8_Click(object sender, EventArgs e)  // boton de agregar Papas Lays
        {
            papasLays.Enqueue(cantidad);
            cantidad++;
            lpapasLays.Text = papasLays.Count.ToString();
        }

        private void button9_Click(object sender, EventArgs e)  // boton de agregar Meneitos
        {
            meneitos.Enqueue(cantidad);
            cantidad++;
            lmeneitos.Text = meneitos.Count.ToString();
        }

        private void button10_Click(object sender, EventArgs e)  // boton de agregar Almendras
        {
            almendras.Enqueue(cantidad);
            cantidad++;
            lalmendras.Text = almendras.Count.ToString();
        }

        private void button11_Click(object sender, EventArgs e)  // boton de agregar Nachos
        {
            nachos.Enqueue(cantidad);
            cantidad++;
            lnachos.Text = nachos.Count.ToString();
        }

        private void button12_Click(object sender, EventArgs e)  // boton de agregar Palitos Horneados
        {
            palitosHorneados.Enqueue(cantidad);
            cantidad++;
            lpalitos.Text = palitosHorneados.Count.ToString();
        }

        private void button13_Click(object sender, EventArgs e)  // boton de agregar Nueces
        {
            nueces.Enqueue(cantidad);
            cantidad++;
            lnueces.Text = nueces.Count.ToString();
        }

        private void button14_Click(object sender, EventArgs e)  //boton de agregarsanck keto
        {
            snackKeto.Enqueue(cantidad);
            cantidad++;
            lsnackKeto.Text = snackKeto.Count.ToString();
        }

        private void button15_Click(object sender, EventArgs e)  // boton de agregar wafers fresa
        {
            wafersFresa.Enqueue(cantidad);
            cantidad++;
            lwafers.Text = wafersFresa.Count.ToString();
        }

        private void button16_Click(object sender, EventArgs e)  // boton de agregar empanadas
        {
            empanadas.Enqueue(cantidad);
            cantidad++;
            lempanadas.Text = empanadas.Count.ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}

