namespace ModifiedTicketingSystem
{
    public class ScannerFeedback {
        private string _successMsg;
        private string _failureMsg;

        // Possibly unnecessary, move to scanner class?
        public ScannerFeedback(string failureMsg, string successMsg) {
            _failureMsg = failureMsg;
            _successMsg = successMsg;
        }

        public void ShowSuccess() {
            
        }

        public void ShowFailures() {
            
        }
    }
}