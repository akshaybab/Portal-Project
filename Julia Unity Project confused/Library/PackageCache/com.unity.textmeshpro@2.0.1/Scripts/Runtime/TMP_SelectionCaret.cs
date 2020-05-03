<<<<<<< HEAD
﻿using UnityEngine;
using UnityEngine.UI;


namespace TMPro
{
    /// <summary>
    /// A simple component that can be added to a newly created object where inheriting from MaskableGraphic is needed.
    /// </summary>
    public class TMP_SelectionCaret : MaskableGraphic
    {

        /// <summary>
        /// Override to Cull function of MaskableGraphic to prevent Culling.
        /// </summary>
        /// <param name="clipRect"></param>
        /// <param name="validRect"></param>
        public override void Cull(Rect clipRect, bool validRect)
        {
            //base.Cull(clipRect, validRect);
        }
    }
}
=======
﻿using UnityEngine;
using UnityEngine.UI;


namespace TMPro
{
    /// <summary>
    /// A simple component that can be added to a newly created object where inheriting from MaskableGraphic is needed.
    /// </summary>
    public class TMP_SelectionCaret : MaskableGraphic
    {

        /// <summary>
        /// Override to Cull function of MaskableGraphic to prevent Culling.
        /// </summary>
        /// <param name="clipRect"></param>
        /// <param name="validRect"></param>
        public override void Cull(Rect clipRect, bool validRect)
        {
            //base.Cull(clipRect, validRect);
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
