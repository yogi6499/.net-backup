using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
namespace Intern_Salary
{
    class InternFile
    {
       public InternFile() { }
        public string Serialize(List<Intern> list)
        {
            FileStream fs = new FileStream(@"F:\InternSalary.txt", FileMode.Create,FileAccess.Write);
            XmlSerializer formatter = new XmlSerializer(typeof(List<Intern>));
            formatter.Serialize(fs, list);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, list);
            fs.Close();
            return "Successfully serialized list to text file";
        }
        public List<Intern> DeSerialize(List<Intern> list)
        {
            
            XmlSerializer formatter = new XmlSerializer(typeof(List<Intern>));
            FileStream fs=new FileStream(@"F:\InternSalary.txt", FileMode.Open, FileAccess.Read);
            list=(List<Intern>)formatter.Deserialize(fs);
            //BinaryFormatter bf = new BinaryFormatter();
            //list=(List<Intern>)bf.Deserialize(fs);
            Console.WriteLine("Successfully deserialized");
            return list;
        }
    }
}
