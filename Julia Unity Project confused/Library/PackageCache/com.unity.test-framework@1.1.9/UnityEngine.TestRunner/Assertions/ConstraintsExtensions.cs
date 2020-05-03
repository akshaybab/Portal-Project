<<<<<<< HEAD
using NUnit.Framework.Constraints;

namespace UnityEngine.TestTools.Constraints
{
    public static class ConstraintExtensions
    {
        public static AllocatingGCMemoryConstraint AllocatingGCMemory(this ConstraintExpression chain)
        {
            var constraint = new AllocatingGCMemoryConstraint();
            chain.Append(constraint);
            return constraint;
        }
    }
}
=======
using NUnit.Framework.Constraints;

namespace UnityEngine.TestTools.Constraints
{
    public static class ConstraintExtensions
    {
        public static AllocatingGCMemoryConstraint AllocatingGCMemory(this ConstraintExpression chain)
        {
            var constraint = new AllocatingGCMemoryConstraint();
            chain.Append(constraint);
            return constraint;
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
