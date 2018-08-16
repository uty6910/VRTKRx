using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnIoUsedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, InteractableObjectEventArgs>> onIoUsed;

        public void OnIoUsed(object sender, InteractableObjectEventArgs e)
        {
            if (onIoUsed != null)
            {
                onIoUsed.OnNext(new Tuple<object, InteractableObjectEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoUsedAsObservable()
        {
            return onIoUsed ?? (onIoUsed = new Subject<Tuple<object, InteractableObjectEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onIoUsed != null)
            {
                onIoUsed.OnCompleted();
            }
        }
    }
}