﻿using System.Text.Json.Serialization;

namespace Tingle.Dependabot.Models;

public sealed record UpdateJobResponse(UpdateJobData Data);
public sealed record UpdateJobData(UpdateJobAttributes Attributes);

public sealed record UpdateJobAttributes()
{
    public UpdateJobAttributes(UpdateJob job) : this()
    {
    }

    [JsonPropertyName("allowed-updates")]
    public required IEnumerable<object> AllowedUpdates { get; set; }

    [JsonPropertyName("credentials-metadata")]
    public required IEnumerable<object> CredentialsMetadata { get; set; }

    [JsonPropertyName("dependencies")]
    public required IEnumerable<object> Dependencies { get; set; }

    [JsonPropertyName("directory")]
    public required string Directory { get; set; }

    [JsonPropertyName("existing-pull-requests")]
    public required IEnumerable<object> ExistingPullRequests { get; set; }

    [JsonPropertyName("ignore-conditions")]
    public required IEnumerable<object> IgnoreConditions { get; set; }

    [JsonPropertyName("security-advisories")]
    public required IEnumerable<object> SecurityAdvisories { get; set; }

    [JsonPropertyName("package_manager")]
    public required DependabotPackageEcosystem PackageManager { get; set; }

    [JsonPropertyName("repo-name")]
    public required string RepoName { get; set; }

    [JsonPropertyName("source")]
    public required UpdateJobAttributesSource Source { get; set; }

    [JsonPropertyName("lockfile-only")]
    public bool? LockfileOnly { get; set; }

    [JsonPropertyName("requirements-update-strategy")]
    public string? RequirementsUpdateStrategy { get; set; }

    [JsonPropertyName("update-subdependencies")]
    public bool? UpdateSubdependencies { get; set; }

    [JsonPropertyName("updating-a-pull-request")]
    public bool? UpdatingAPullRequest { get; set; }

    [JsonPropertyName("vendor-dependencies")]
    public bool? VendorDependencies { get; set; }

    [JsonPropertyName("security-updates-only")]
    public bool? SecurityUpdatesOnly { get; set; }
}

public sealed record UpdateJobAttributesSource()
{
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    [JsonPropertyName("directory")]
    public required string Directory { get; set; }

    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    [JsonPropertyName("api-endpoint")]
    public string? ApiEndpoint { get; set; }
}
