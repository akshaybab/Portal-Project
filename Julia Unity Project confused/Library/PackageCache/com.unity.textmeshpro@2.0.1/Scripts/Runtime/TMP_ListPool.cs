<<<<<<< HEAD
﻿using System.Collections.Generic;


namespace TMPro
{
    internal static class TMP_ListPool<T>
    {      
        // Object pool to avoid allocations.
        private static readonly TMP_ObjectPool<List<T>> s_ListPool = new TMP_ObjectPool<List<T>>(null, l => l.Clear());

        public static List<T> Get()
        {
            return s_ListPool.Get();
        }

        public static void Release(List<T> toRelease)
        {
            s_ListPool.Release(toRelease);
        }
    }
=======
﻿using System.Collections.Generic;


namespace TMPro
{
    internal static class TMP_ListPool<T>
    {      
        // Object pool to avoid allocations.
        private static readonly TMP_ObjectPool<List<T>> s_ListPool = new TMP_ObjectPool<List<T>>(null, l => l.Clear());

        public static List<T> Get()
        {
            return s_ListPool.Get();
        }

        public static void Release(List<T> toRelease)
        {
            s_ListPool.Release(toRelease);
        }
    }
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
}