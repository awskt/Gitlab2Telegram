using System.Text.Json.Serialization;

namespace Gitlab2Telegram {
    abstract class Generated { }

    public record Author(
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("email")] string Email
    );

    public record Commit(
        [property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("message")] string Message,
        [property: JsonPropertyName("title")] string Title,
        [property: JsonPropertyName("timestamp")] DateTime Timestamp,
        [property: JsonPropertyName("url")] string Url,
        [property: JsonPropertyName("author")] Author Author,
        [property: JsonPropertyName("added")] IReadOnlyList<string> Added,
        [property: JsonPropertyName("modified")] IReadOnlyList<string> Modified,
        [property: JsonPropertyName("removed")] IReadOnlyList<object> Removed,
        [property: JsonPropertyName("sha")] string Sha,
        [property: JsonPropertyName("author_name")] string AuthorName,
        [property: JsonPropertyName("author_email")] string AuthorEmail,
        [property: JsonPropertyName("status")] string Status,
        [property: JsonPropertyName("duration")] object Duration,
        [property: JsonPropertyName("started_at")] object StartedAt,
        [property: JsonPropertyName("finished_at")] object FinishedAt
    );

    public record Project(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("description")] string Description,
        [property: JsonPropertyName("web_url")] string WebUrl,
        [property: JsonPropertyName("avatar_url")] object AvatarUrl,
        [property: JsonPropertyName("git_ssh_url")] string GitSshUrl,
        [property: JsonPropertyName("git_http_url")] string GitHttpUrl,
        [property: JsonPropertyName("namespace")] string Namespace,
        [property: JsonPropertyName("visibility_level")] int VisibilityLevel,
        [property: JsonPropertyName("path_with_namespace")] string PathWithNamespace,
        [property: JsonPropertyName("default_branch")] string DefaultBranch,
        [property: JsonPropertyName("homepage")] string Homepage,
        [property: JsonPropertyName("url")] string Url,
        [property: JsonPropertyName("ssh_url")] string SshUrl,
        [property: JsonPropertyName("http_url")] string HttpUrl
    );

    public record Repository(
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("url")] string Url,
        [property: JsonPropertyName("description")] string Description,
        [property: JsonPropertyName("homepage")] string Homepage,
        [property: JsonPropertyName("git_http_url")] string GitHttpUrl,
        [property: JsonPropertyName("git_ssh_url")] string GitSshUrl,
        [property: JsonPropertyName("visibility_level")] int VisibilityLevel
    );
    public record Root(
        [property: JsonPropertyName("object_kind")] string ObjectKind,
        [property: JsonPropertyName("event_name")] string EventName,
        [property: JsonPropertyName("before")] string Before,
        [property: JsonPropertyName("after")] string After,
        [property: JsonPropertyName("checkout_sha")] string CheckoutSha,
        [property: JsonPropertyName("user_id")] int UserId,
        [property: JsonPropertyName("user_name")] string UserName,
        [property: JsonPropertyName("user_username")] string UserUsername,
        [property: JsonPropertyName("user_email")] string UserEmail,
        [property: JsonPropertyName("user_avatar")] string UserAvatar,
        [property: JsonPropertyName("project_id")] int ProjectId,
        [property: JsonPropertyName("project")] Project Project,
        [property: JsonPropertyName("repository")] Repository Repository,
        [property: JsonPropertyName("commits")] IReadOnlyList<Commit> Commits,
        [property: JsonPropertyName("total_commits_count")] int TotalCommitsCount,
        [property: JsonPropertyName("tag")] bool Tag,
        [property: JsonPropertyName("before_sha")] string BeforeSha,
        [property: JsonPropertyName("sha")] string Sha,
        [property: JsonPropertyName("build_id")] int BuildId,
        [property: JsonPropertyName("build_name")] string BuildName,
        [property: JsonPropertyName("build_stage")] string BuildStage,
        [property: JsonPropertyName("build_status")] string BuildStatus,
        [property: JsonPropertyName("build_created_at")] DateTime BuildCreatedAt,
        [property: JsonPropertyName("build_started_at")] object BuildStartedAt,
        [property: JsonPropertyName("build_finished_at")] object BuildFinishedAt,
        [property: JsonPropertyName("build_duration")] object BuildDuration,
        [property: JsonPropertyName("build_allow_failure")] bool BuildAllowFailure,
        [property: JsonPropertyName("build_failure_reason")] string BuildFailureReason,
        [property: JsonPropertyName("pipeline_id")] int PipelineId,
        [property: JsonPropertyName("project_name")] string ProjectName,
        [property: JsonPropertyName("user")] User User,
        [property: JsonPropertyName("commit")] Commit Commit,
        [property: JsonPropertyName("runner")] Runner Runner,
        [property: JsonPropertyName("environment")] object Environment,
        // deploy
        [property: JsonPropertyName("status")] string Status,
        [property: JsonPropertyName("status_changed_at")] string StatusChangedAt,
        [property: JsonPropertyName("deployment_id")] int DeploymentId,
        [property: JsonPropertyName("deployable_id")] int DeployableId,
        [property: JsonPropertyName("deployable_url")] string DeployableUrl,
        [property: JsonPropertyName("short_sha")] string ShortSha,
        [property: JsonPropertyName("user_url")] string UserUrl,
        [property: JsonPropertyName("commit_url")] string CommitUrl,
        [property: JsonPropertyName("commit_title")] string CommitTitle,
        // issue
        [property: JsonPropertyName("event_type")] string EventType,
        [property: JsonPropertyName("object_attributes")] ObjectAttributes ObjectAttributes,
        [property: JsonPropertyName("labels")] IReadOnlyList<object> Labels
    );


    public record Runner(
        [property: JsonPropertyName("active")] bool Active,
        [property: JsonPropertyName("runner_type")] string RunnerType,
        [property: JsonPropertyName("is_shared")] bool IsShared,
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("description")] string Description,
        [property: JsonPropertyName("tags")] IReadOnlyList<string> Tags
    );

    public record User(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("email")] string Email,
        [property: JsonPropertyName("avatar_url")] string AvatarUrl
    );

    // issue
    public record ObjectAttributes(
       [property: JsonPropertyName("author_id")] int AuthorId,
       [property: JsonPropertyName("closed_at")] object ClosedAt,
       [property: JsonPropertyName("confidential")] bool Confidential,
       [property: JsonPropertyName("created_at")] string CreatedAt,
       [property: JsonPropertyName("description")] string Description,
       [property: JsonPropertyName("discussion_locked")] object DiscussionLocked,
       [property: JsonPropertyName("due_date")] string DueDate,
       [property: JsonPropertyName("id")] int Id,
       [property: JsonPropertyName("iid")] int Iid,
       [property: JsonPropertyName("last_edited_at")] object LastEditedAt,
       [property: JsonPropertyName("last_edited_by_id")] object LastEditedById,
       [property: JsonPropertyName("milestone_id")] object MilestoneId,
       [property: JsonPropertyName("moved_to_id")] object MovedToId,
       [property: JsonPropertyName("duplicated_to_id")] object DuplicatedToId,
       [property: JsonPropertyName("project_id")] int ProjectId,
       [property: JsonPropertyName("relative_position")] int RelativePosition,
       [property: JsonPropertyName("state_id")] int StateId,
       [property: JsonPropertyName("time_estimate")] int TimeEstimate,
       [property: JsonPropertyName("title")] string Title,
       [property: JsonPropertyName("updated_at")] string UpdatedAt,
       [property: JsonPropertyName("updated_by_id")] object UpdatedById,
       [property: JsonPropertyName("weight")] object Weight,
       [property: JsonPropertyName("url")] string Url,
       [property: JsonPropertyName("total_time_spent")] int TotalTimeSpent,
       [property: JsonPropertyName("time_change")] int TimeChange,
       [property: JsonPropertyName("human_total_time_spent")] object HumanTotalTimeSpent,
       [property: JsonPropertyName("human_time_change")] object HumanTimeChange,
       [property: JsonPropertyName("human_time_estimate")] object HumanTimeEstimate,
       [property: JsonPropertyName("assignee_ids")] IReadOnlyList<object> AssigneeIds,
       [property: JsonPropertyName("assignee_id")] object AssigneeId,
       [property: JsonPropertyName("labels")] IReadOnlyList<object> Labels,
       [property: JsonPropertyName("state")] string State,
       [property: JsonPropertyName("severity")] string Severity
   );
}
