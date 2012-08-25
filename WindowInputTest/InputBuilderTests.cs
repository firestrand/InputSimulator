using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsInput;
using WindowsInput.Native;

namespace WindowInputTest
{
    [TestClass]
    public class InputBuilderTests
    {
        [TestMethod]
        public void AddKeyDown()
        {
            var builder = new InputBuilder();
            Assert.IsFalse(builder.ToArray().Any());
            builder.AddKeyDown(VirtualKeyCode.VK_A);
            Assert.AreEqual(builder.Count(), 1);
            Assert.AreEqual(builder[0].Type,(uint)InputType.Keyboard);
            Assert.AreEqual(builder[0].Data.Keyboard.KeyCode, (ushort)VirtualKeyCode.VK_A);
        }
    }
}
