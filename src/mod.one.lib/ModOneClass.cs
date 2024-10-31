using mod.two.lib;

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
    }
}