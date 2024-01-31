using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacasWPF.Models
{
    public class Vaca : IEditableObject
    {

        #region Constructores

        public Vaca() { }

        public Vaca(int id, string nomMunicipio, DateOnly f_nacim, DateOnly f_destete, int alzada, int peso, string sexo, string tipo)
        {
            this.id = id;
            this.nomMunicipio = nomMunicipio;
            this.f_nacim = f_nacim;
            this.f_destete = f_destete;
            this.alzada = alzada;
            this.peso = peso;
            this.sexo = sexo;
            this.tipo = tipo;
        }


        #endregion

        #region Propiedades
        [Key] 
        public int id { get; set; }
        
        public string nomMunicipio
        { get; set; }
        [Format("dd/MM/yyyy")]
        public DateOnly f_nacim { get; set; }
        [Format("dd/MM/yyyy")]
        public DateOnly f_destete { get; set; }
        public int alzada { get; set; }
        public int peso { get; set; }
        public string sexo { get; set; }
        public string tipo { get; set; }

        #endregion

        
        #region Implementación de interfaces
        
        private string oldNomMunicipio;
        private DateOnly oldFNacim;
        private DateOnly oldFDestete;
        private int oldAlzada;
        private int oldPeso;
        private string oldSexo;
        private string oldTipo;
        public void BeginEdit()
        {
            oldNomMunicipio = this.nomMunicipio;
            oldFDestete = this.f_destete;
            oldAlzada = this.alzada;
            oldFNacim = this.f_nacim;
            oldPeso = this.peso;
            oldSexo = this.sexo;
            oldTipo = this.tipo;


        }

        public void CancelEdit()
        {
            this.nomMunicipio = oldNomMunicipio;
            this.alzada = oldAlzada;
            this.f_destete = oldFDestete;
            this.f_nacim = oldFNacim;
            this.peso = oldPeso;
            this.sexo = oldSexo;
            this.tipo = oldTipo;
        }

        public void EndEdit()
        {
            
        }
        #endregion
    }

}
