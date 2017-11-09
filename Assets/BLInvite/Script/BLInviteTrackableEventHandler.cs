using UnityEngine;

namespace Assets.BLInvite.Script
{
    public class BLInviteTrackableEventHandler : DefaultTrackableEventHandler
    {
        public Canvas CanvasToEnable;
        public Animator Animator;
        public string Trigger;
        
        protected override void OnTrackingFound()
        {
            CanvasToEnable.enabled = true;
            Animator.enabled = true;
            Animator.SetTrigger(Trigger);
        }

        protected override void OnTrackingLost()
        {
            CanvasToEnable.enabled = false;
            Animator.enabled = false;
        }
    }
}