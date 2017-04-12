using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;  // FileStream

namespace PrototypeExample
{
    // 深克隆
    [Serializable]
    class WeeklyLog
    {
        // 为了简化设计和实现，一份工作周报中，可以包含多个附件
        private Attachment attachment;
        private string name;
        private string date;
        private string content;

        public Attachment Attachment
        {
            get { return attachment; }
            set { attachment = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        
        public WeeklyLog Clone()
        {
            // 浅克隆MemberwiseClone()方法
            // return this.MemberwiseClone() as WeeklyLog;  // 类型转换
            WeeklyLog clone = null;
            FileStream fs = new FileStream("Temp.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();  // using
            try
            {
                formatter.Serialize(fs, this); // 序列化
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            FileStream fs1 = new FileStream("Temp.dat", FileMode.Open);
            BinaryFormatter formatter1 = new BinaryFormatter();
            try
            {
                clone = (WeeklyLog)formatter1.Deserialize(fs1);//反序列化
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs1.Close();
            }
            return clone;
        }
         
    }
}
