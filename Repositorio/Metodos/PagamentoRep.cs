using Dominio.Interfaces;
using System.IO;
using System;

namespace Repositorio.Metodos{
    public class PagamentoRep:ICRUD{
        public string Cadastrar(){
            string msg="";
            StreamWriter rw = null;
            FileInfo fi = null;
            try {
                fi = new FileInfo("Pagamentos.txt");
                rw = new StreamWriter("Pagamentos.txt",true);
                if (fi.Exists){

                }


            }
            catch (Exception e){
                msg = "O pagamento não foi salvo. Ocorreu um erro: "+e.Message;

            }
            finally{
                rw.Close();
            }
            return msg;
        }
        public string Consultar(){
            string msg="";
            return msg;
        }
    }
}