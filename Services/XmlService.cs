using projektPO.Models;
using System.IO;
using System.Xml.Serialization;

namespace projektPO.Services
{
    public static class XmlService
    {
        public static WorkPointsValue GetWorkingPoints()
        {
            var serializer = new XmlSerializer(typeof(WorkPointsValue));
            var path = "../../ValuesConfig.xml";
            var reader = new StreamReader(path);
            var workPointsValue = (WorkPointsValue)serializer.Deserialize(reader);
            reader.Close();
            return workPointsValue;
        }
    }
}
