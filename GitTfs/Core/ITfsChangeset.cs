﻿namespace Sep.Git.Tfs.Core
{
    public interface ITfsChangeset
    {
        TfsChangesetInfo Summary { get; }
        LogEntry Apply(GitIndexInfo index);
    }
}