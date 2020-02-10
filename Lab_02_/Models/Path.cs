using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_02_.Models;
using Lab_02_.Controllers;
namespace Lab_02_.Models
{
    public class Path
    {
       public List<Soda> soda = new List<Soda>();
        public Node node;
        public string inOrder()
        {
            string content = null; 
            var nodes = Paths(node);
            if (nodes != null)
            {
                foreach (var item in nodes)
                {
                    var show =  "Name: " + item.Name + "\n" + "Flavor: " + item.Flavor + "\n" + "Volume: " + item.Volume + "\n" + "Price: " + item.Price + "\n" + "Producer House: " + item.Producer_House;
                    content += show;
                }
            } else
            {
                content = "EMPTY";
            }

            return content;
        }
      
       public List<Soda> Paths(Node node)
        {

            if (node != null)
            {
                Paths(node.leftChild);
                soda.Add(node.leftVal);
                Paths(node.intermideateChild);
                if (node.rightVal != null)
                {
                    Paths(node.rightChild);
                    soda.Add(node.rightVal);
                        
                }
            }
            return soda;
        }
    }
}
