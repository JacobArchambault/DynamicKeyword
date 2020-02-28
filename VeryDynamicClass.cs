namespace DynamicKeyword
{
    class VeryDynamicClass
    {
        private static readonly dynamic myDynamicField = 10;

        public dynamic DynamicProperty { get; set; }
        public dynamic DynamicMethod(dynamic dynamicParam)
        {
            dynamic dynamicLocalVar = "Local variable";

            return dynamicParam is int ? dynamicLocalVar : myDynamicField;
        }
    }
}
