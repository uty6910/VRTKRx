using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnStartMenuReleasedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onStartMenuReleased;

        public void OnStartMenuReleased(object sender, ControllerInteractionEventArgs e)
        {
            if (onStartMenuReleased != null)
            {
                onStartMenuReleased.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnStartMenuReleasedAsObservable()
        {
            return onStartMenuReleased ?? (onStartMenuReleased = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onStartMenuReleased != null)
            {
                onStartMenuReleased.OnCompleted();
            }
        }
    }
}