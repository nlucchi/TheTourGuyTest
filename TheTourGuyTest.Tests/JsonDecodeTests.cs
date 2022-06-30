using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TheTourGuyTest.Tests.JsonModel;

namespace TheTourGuyTest.Tests
{
    [TestClass]
    public class JsonDecodeTests
    {
        [TestMethod]
        public async Task ShoulDeserialize_StarwarsCharacterJsonFile()
        { 
            string jsonContent = await File.ReadAllTextAsync(Path.Combine(Directory.GetCurrentDirectory(), @"JsonData\StarwarsCharacter.json"));
            var jsonModel = JsonSerializer.Deserialize<StarwarsCharacterContainerJsonModel>(jsonContent);

            Assert.IsNotNull(jsonModel);
            Assert.IsNotNull(jsonModel.StarwarsCharacter);
            Assert.AreEqual("Ben Solo", jsonModel.StarwarsCharacter.Person);
            Assert.AreEqual("bsolo@unicef.org", jsonModel.StarwarsCharacter.Email);
            Assert.AreEqual("Sith", jsonModel.StarwarsCharacter.Role);
            Assert.AreEqual("Jedi", jsonModel.StarwarsCharacter.Team);
            Assert.AreEqual("Chandrila", jsonModel.StarwarsCharacter.Home);
            Assert.AreEqual("Leia Organa", jsonModel.StarwarsCharacter.Object);
            Assert.AreEqual("ChildOf", jsonModel.StarwarsCharacter.Relation);
            Assert.AreEqual("Temperate", jsonModel.StarwarsCharacter.Climate);
        }
    }
}