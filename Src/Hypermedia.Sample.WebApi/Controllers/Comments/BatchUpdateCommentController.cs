using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Hypermedia.Sample.Data;
using Hypermedia.Sample.Resources;

namespace Hypermedia.Sample.WebApi.Controllers.Comments
{
    public sealed class BatchUpdateCommentController : ResourceController<Comment, CommentResource>
    {
        /// <summary>
        /// Updates a comment.
        /// </summary>
        /// <returns>The HTTP action result that represents the result of the action.</returns>
        [HttpOptions, HttpPut, Route("v1/comments")]
        public async Task<IHttpActionResult> ExecuteAsync(IReadOnlyList<CommentResource> comments)
        {
            await Task.CompletedTask;

            return NoContent();
        }
    }
}