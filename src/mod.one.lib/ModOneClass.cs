using mod.two.lib;
using mod.three.lib;

namespace mod.one.lib
{
    public class ModOneClass
    {
        public string GetModOneString()
        {
            var x = InstanceOfModTwo.Blah();
            return "ModOneClass.GetModOneString()";
        }

        public ModTwoClass InstanceOfModTwo { get; set; }
        public ModThreeClass InstanceOfModThree { get; set; }
    }
}