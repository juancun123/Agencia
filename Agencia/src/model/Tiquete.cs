using System;
using System.Collections.Generic;
using System.Text;

namespace Agencia.src.model
{
    class Tiquete
    {
        private int nroTiquete;
        private string ciudad;
        private int diasHospedaje;
        private float costoPersona;
        private float costoComida;
        private float descuentos;
        private float costoAlojamiento;
        private float subtotal;
        private float totalPago;
        private string pago;

        public int NroTiquete { get => nroTiquete; set => nroTiquete = value; }
        public string Ciudad { 
            get {return  ciudad; } 
            set {
                ciudad = value;                
            }
        } 
        public int DiasHospedaje { get => diasHospedaje; set => diasHospedaje = value; }
        public float CostoPersona { get => costoPersona; set => costoPersona = value; }
        public float CostoComida { get => costoComida; set => costoComida = value; }
        public float Descuentos { get => descuentos; set => descuentos = value; }
        public float Subtotal { get => subtotal; set => subtotal = value; }
        public float TotalPago { get => totalPago; set => totalPago = value; }
        public string Pago { get => pago; set => pago = value; }
        public float CostoAlojamiento { get => costoAlojamiento; set => costoAlojamiento = value; }

        public float[] Liquidar(String ciudad, int dias,int personas)
        {
            float totalTiquete = NroTiquete * CostoPersona;
            float totalComida = NroTiquete * CostoComida * DiasHospedaje;
            float totalAlojamiento = NroTiquete * CostoAlojamiento * DiasHospedaje;
            float porcentajeDescuento = nroTiquete > 10 ? 0.15f : (nroTiquete > 5 ? 0.1f : 0);
            porcentajeDescuento += this.ciudad == "Ciudad A" || this.ciudad == "Ciudad B" ? 0.02f : 0.05f;            
            porcentajeDescuento += this.pago == "Efectivo" ? 0.04f : 0.015f;            
            this.subtotal = totalAlojamiento + totalTiquete + totalComida;
            this.descuentos = subtotal * porcentajeDescuento;
            this.totalPago = subtotal - descuentos;
            return new float[] { totalAlojamiento,totalTiquete,totalComida};
        }

        public void reserva()
        {
            switch (ciudad)
            {
                case "Ciudad A":
                    diasHospedaje = 5;
                    costoAlojamiento = 15000;
                    costoPersona = 100000;
                    costoComida = 9000;
                    break;
                case "Ciudad B":
                    diasHospedaje = 4;
                    costoAlojamiento = 12500;
                    costoPersona = 120000;
                    costoComida = 11000;
                    break;
                case "Ciudad C":
                    diasHospedaje = 8;
                    costoAlojamiento = 14000;
                    costoPersona = 110000;
                    costoComida = 12000;
                    break;
                case "Ciudad D":
                    diasHospedaje = 6;
                    costoAlojamiento = 17000;
                    costoPersona = 115000;
                    costoComida = 10000;
                    break;
                default:
                    diasHospedaje = 0;
                    costoAlojamiento = 0;
                    costoPersona = 0;
                    costoComida = 0;
                    break;
            }
        }
    }
}
