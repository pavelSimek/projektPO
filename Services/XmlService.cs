using projektPO.Models;
using System.IO;
using System.Xml.Serialization;

namespace projektPO.Services
{
    public static class XmlService
    {
        public static WorkPointsValueModel GetWorkingPoints()
        {
            var serializer = new XmlSerializer(typeof(WorkPointsValueModel));
            var path = "../../ValuesConfig.xml";
            var reader = new StreamReader(path);
            var workPointsValue = (WorkPointsValueModel)serializer.Deserialize(reader);
            reader.Close();
            return workPointsValue;
        }
    }
}
