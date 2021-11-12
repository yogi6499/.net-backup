using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Employee_Management_system
{
    class EmployeeFile
    {
        
        public void  Serialize(List<Employee> list)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\Employee.txt", FileMode.Create, FileAccess.Write);
                XmlSerializer formatter = new XmlSerializer(typeof(List<Employee>));
                formatter.Serialize(fs, list);

                fs.Close();
                Console.WriteLine("Successfully serialized list to text file");
            }
            catch(Exception ex)
            {
                Console.WriteLine("File Not Found and the error message is "+ex.Message);
            }
            
        }
        public List<Employee> DeSerialize(List<Employee> list)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Employee>));
                FileStream fs = new FileStream(@"F:\Employee.txt", FileMode.Open, FileAccess.Read);
                list = (List<Employee>)formatter.Deserialize(fs);

                Console.WriteLine("Successfully deserialized");
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File Not Found and the error message is " + ex.Message);
            }
            return list;
        }
    }
}
