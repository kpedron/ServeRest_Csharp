using NUnit.Framework;
using ServeRest.ResponseDataTypes;
using ServeRest.Rest;

namespace ServeRest.Tests
{
    [TestFixture]
    public class Users
    {
        private Requests restApi = new Requests();

        [TestCase(TestName = "Listando todos os usuarios")]
        public void TestGetAllUsers()
        {
            var response = restApi.SendGet("usuarios");

            UsuariosResponse contentUsuarios = restApi.GetContent<UsuariosResponse>(response);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(200, (int)response.StatusCode);
                Assert.AreEqual(contentUsuarios.Usuarios[0].Nome, "Fulano da Silva");
                Assert.AreEqual(contentUsuarios.Usuarios[0].Email, "fulano@qa.com");
                Assert.AreEqual(contentUsuarios.Usuarios[0].Administrador, "true");

                Assert.That(contentUsuarios.Quantidade > 0);
            });
        }
    }
}

