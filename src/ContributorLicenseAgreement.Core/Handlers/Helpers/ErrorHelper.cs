using System;

namespace ContributorLicenseAgreement.Core.Handlers.Helpers
{
    public class ErrorHelper
    {
        private readonly CommentHelper commentHelper;

        public ErrorHelper(CommentHelper commentHelper)
        {
            this.commentHelper = commentHelper;
        }

        public void HandleError(Exception ex)
        {
            // Handle the error and perform necessary actions
            // For example, log the error, send notifications, etc.
        }

        // Other error handling methods...

        // Example method that uses CommentHelper
        public void HandleCommentError(string gitHubUser, string company)
        {
            var comment = commentHelper.GenerateFailureComment(gitHubUser, company);
            // Perform actions with the generated comment
        }
    }
}
