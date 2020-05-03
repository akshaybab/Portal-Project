<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;


namespace TMPro
{
    /// <summary>
    /// Custom text input validator where user can implement their own custom character validation.
    /// </summary>
    [System.Serializable]
    public abstract class TMP_InputValidator : ScriptableObject
    {
        public abstract char Validate(ref string text, ref int pos, char ch);
    }
}
=======
﻿using UnityEngine;
using System.Collections;


namespace TMPro
{
    /// <summary>
    /// Custom text input validator where user can implement their own custom character validation.
    /// </summary>
    [System.Serializable]
    public abstract class TMP_InputValidator : ScriptableObject
    {
        public abstract char Validate(ref string text, ref int pos, char ch);
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
