using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnIoUntouchedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, InteractableObjectEventArgs>> onIoUntouched;

        public void OnIoUntouched(object sender, InteractableObjectEventArgs e)
        {
            if (onIoUntouched != null)
            {
                onIoUntouched.OnNext(new Tuple<object, InteractableObjectEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoUntouchedAsObservable()
        {
            return onIoUntouched ?? (onIoUntouched = new Subject<Tuple<object, InteractableObjectEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onIoUntouched != null)
            {
                onIoUntouched.OnCompleted();
            }
        }
    }
}