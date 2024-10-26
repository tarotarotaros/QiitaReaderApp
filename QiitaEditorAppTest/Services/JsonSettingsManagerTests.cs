using QiitaEditorApp.Services;

namespace QiitaEditorAppTest.Services
{
    public class JsonSettingsManagerTests : IDisposable
    {
        private readonly string _filePath = "setting.json";

        public JsonSettingsManagerTests()
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
        }

        public void Dispose()
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
        }

        [Fact]
        public void Add_AddsNewEntry()
        {
            var manager = new JsonSettingsManager(_filePath);
            manager.Add("Key1", "Value1");

            var result = manager.Read("Key1");
            Assert.Equal("Value1", result);
        }

        [Fact]
        public void Read_ReturnsCorrectValue()
        {
            var manager = new JsonSettingsManager(_filePath);
            manager.Add("Key2", "Value2");

            var result = manager.Read("Key2");
            Assert.Equal("Value2", result);
        }

        [Fact]
        public void Update_UpdatesExistingEntry()
        {
            var manager = new JsonSettingsManager(_filePath);
            manager.Add("Key3", "OldValue");

            manager.Update("Key3", "NewValue");

            var result = manager.Read("Key3");
            Assert.Equal("NewValue", result);
        }

        [Fact]
        public void Delete_RemovesEntry()
        {
            var manager = new JsonSettingsManager(_filePath);
            manager.Add("Key4", "Value4");

            manager.Delete("Key4");

            var result = manager.Read("Key4");
            Assert.Null(result);
        }

        [Fact]
        public void Add_ThrowsException_WhenKeyExists()
        {
            var manager = new JsonSettingsManager(_filePath);
            manager.Add("Key5", "Value5");

            Assert.Throws<Exception>(() => manager.Add("Key5", "AnotherValue"));
        }

        [Fact]
        public void Update_ThrowsException_WhenKeyDoesNotExist()
        {
            var manager = new JsonSettingsManager(_filePath);

            Assert.Throws<Exception>(() => manager.Update("NonExistingKey", "Value"));
        }

        [Fact]
        public void Delete_ThrowsException_WhenKeyDoesNotExist()
        {
            var manager = new JsonSettingsManager(_filePath);

            Assert.Throws<Exception>(() => manager.Delete("NonExistingKey"));
        }

        [Fact]
        public void ExistsKey_ReturnsTrue_WhenKeyExists()
        {
            var manager = new JsonSettingsManager(_filePath);
            manager.Add("Key6", "Value6");

            var exists = manager.ExistsKey("Key6");

            Assert.True(exists);
        }

        [Fact]
        public void ExistsKey_ReturnsFalse_WhenKeyDoesNotExist()
        {
            var manager = new JsonSettingsManager(_filePath);

            var exists = manager.ExistsKey("NonExistingKey");

            Assert.False(exists);
        }
    }
}
