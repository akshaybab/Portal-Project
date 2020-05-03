<<<<<<< HEAD
using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;

namespace Packages.Rider.Editor.UnitTesting
{
  public class CallbackData : ScriptableSingleton<CallbackData>
  {
    public bool isRider;

    [UsedImplicitly] public static event EventHandler Changed = (sender, args) => { }; 

    internal void RaiseChangedEvent()
    {
      Changed(null, EventArgs.Empty);
    }

    public List<TestEvent> events = new List<TestEvent>();

    [UsedImplicitly]
    public void Clear()
    {
      events.Clear();
    }
  }
=======
using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;

namespace Packages.Rider.Editor.UnitTesting
{
  public class CallbackData : ScriptableSingleton<CallbackData>
  {
    public bool isRider;

    [UsedImplicitly] public static event EventHandler Changed = (sender, args) => { }; 

    internal void RaiseChangedEvent()
    {
      Changed(null, EventArgs.Empty);
    }

    public List<TestEvent> events = new List<TestEvent>();

    [UsedImplicitly]
    public void Clear()
    {
      events.Clear();
    }
  }
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
}