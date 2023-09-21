using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DirectX.Common.DirectWrite;
using Opc.UaFx;
using Opc.UaFx.Client;

namespace WpfApp8
{
    
    internal class opcComm
    {
        OpcClient client = new OpcClient("opc.tcp://192.168.1.10:4840/");

        public string opcRead(string addres)
        {
            return client.ReadNode(addres).ToString();
        }
        
        public void opcWrite(string group, string address, object values)
        {
            string addresBase = "ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.";

            switch (group)

            {
                case "Eksen_Ayarlar":
                    client.WriteNode(addresBase+group+address, values);
                    break;
                
            }
            
        }



    }
}
