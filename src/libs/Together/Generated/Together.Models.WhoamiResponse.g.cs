#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Together
{
    /// <summary>
    /// The caller. `type` names the variant and which fields are present.
    /// </summary>
    public readonly partial struct WhoamiResponse : global::System.IEquatable<WhoamiResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Together.WhoamiResponseDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.WhoamiProjectApiKey? ProjectApiKey { get; init; }
#else
        public global::Together.WhoamiProjectApiKey? ProjectApiKey { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProjectApiKey))]
#endif
        public bool IsProjectApiKey => ProjectApiKey != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProjectApiKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.WhoamiProjectApiKey? value)
        {
            value = ProjectApiKey;
            return IsProjectApiKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.WhoamiProjectApiKey PickProjectApiKey() => ProjectApiKey is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProjectApiKey' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.WhoamiOrgApiKey? OrgApiKey { get; init; }
#else
        public global::Together.WhoamiOrgApiKey? OrgApiKey { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrgApiKey))]
#endif
        public bool IsOrgApiKey => OrgApiKey != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOrgApiKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.WhoamiOrgApiKey? value)
        {
            value = OrgApiKey;
            return IsOrgApiKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.WhoamiOrgApiKey PickOrgApiKey() => OrgApiKey is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrgApiKey' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.WhoamiUserJwt? UserJwt { get; init; }
#else
        public global::Together.WhoamiUserJwt? UserJwt { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserJwt))]
#endif
        public bool IsUserJwt => UserJwt != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserJwt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.WhoamiUserJwt? value)
        {
            value = UserJwt;
            return IsUserJwt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.WhoamiUserJwt PickUserJwt() => UserJwt is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserJwt' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.WhoamiUserOrgJwt? UserOrgJwt { get; init; }
#else
        public global::Together.WhoamiUserOrgJwt? UserOrgJwt { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserOrgJwt))]
#endif
        public bool IsUserOrgJwt => UserOrgJwt != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserOrgJwt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.WhoamiUserOrgJwt? value)
        {
            value = UserOrgJwt;
            return IsUserOrgJwt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.WhoamiUserOrgJwt PickUserOrgJwt() => UserOrgJwt is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserOrgJwt' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Together.WhoamiUserOrgProjectJwt? UserOrgProjectJwt { get; init; }
#else
        public global::Together.WhoamiUserOrgProjectJwt? UserOrgProjectJwt { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserOrgProjectJwt))]
#endif
        public bool IsUserOrgProjectJwt => UserOrgProjectJwt != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserOrgProjectJwt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Together.WhoamiUserOrgProjectJwt? value)
        {
            value = UserOrgProjectJwt;
            return IsUserOrgProjectJwt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Together.WhoamiUserOrgProjectJwt PickUserOrgProjectJwt() => UserOrgProjectJwt is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserOrgProjectJwt' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WhoamiResponse(global::Together.WhoamiProjectApiKey value) => new WhoamiResponse((global::Together.WhoamiProjectApiKey?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.WhoamiProjectApiKey?(WhoamiResponse @this) => @this.ProjectApiKey;

        /// <summary>
        ///
        /// </summary>
        public WhoamiResponse(global::Together.WhoamiProjectApiKey? value)
        {
            ProjectApiKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WhoamiResponse FromProjectApiKey(global::Together.WhoamiProjectApiKey? value) => new WhoamiResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WhoamiResponse(global::Together.WhoamiOrgApiKey value) => new WhoamiResponse((global::Together.WhoamiOrgApiKey?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.WhoamiOrgApiKey?(WhoamiResponse @this) => @this.OrgApiKey;

        /// <summary>
        ///
        /// </summary>
        public WhoamiResponse(global::Together.WhoamiOrgApiKey? value)
        {
            OrgApiKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WhoamiResponse FromOrgApiKey(global::Together.WhoamiOrgApiKey? value) => new WhoamiResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WhoamiResponse(global::Together.WhoamiUserJwt value) => new WhoamiResponse((global::Together.WhoamiUserJwt?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.WhoamiUserJwt?(WhoamiResponse @this) => @this.UserJwt;

        /// <summary>
        ///
        /// </summary>
        public WhoamiResponse(global::Together.WhoamiUserJwt? value)
        {
            UserJwt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WhoamiResponse FromUserJwt(global::Together.WhoamiUserJwt? value) => new WhoamiResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WhoamiResponse(global::Together.WhoamiUserOrgJwt value) => new WhoamiResponse((global::Together.WhoamiUserOrgJwt?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.WhoamiUserOrgJwt?(WhoamiResponse @this) => @this.UserOrgJwt;

        /// <summary>
        ///
        /// </summary>
        public WhoamiResponse(global::Together.WhoamiUserOrgJwt? value)
        {
            UserOrgJwt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WhoamiResponse FromUserOrgJwt(global::Together.WhoamiUserOrgJwt? value) => new WhoamiResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WhoamiResponse(global::Together.WhoamiUserOrgProjectJwt value) => new WhoamiResponse((global::Together.WhoamiUserOrgProjectJwt?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Together.WhoamiUserOrgProjectJwt?(WhoamiResponse @this) => @this.UserOrgProjectJwt;

        /// <summary>
        ///
        /// </summary>
        public WhoamiResponse(global::Together.WhoamiUserOrgProjectJwt? value)
        {
            UserOrgProjectJwt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WhoamiResponse FromUserOrgProjectJwt(global::Together.WhoamiUserOrgProjectJwt? value) => new WhoamiResponse(value);

        /// <summary>
        ///
        /// </summary>
        public WhoamiResponse(
            global::Together.WhoamiResponseDiscriminatorType? type,
            global::Together.WhoamiProjectApiKey? projectApiKey,
            global::Together.WhoamiOrgApiKey? orgApiKey,
            global::Together.WhoamiUserJwt? userJwt,
            global::Together.WhoamiUserOrgJwt? userOrgJwt,
            global::Together.WhoamiUserOrgProjectJwt? userOrgProjectJwt
            )
        {
            Type = type;

            ProjectApiKey = projectApiKey;
            OrgApiKey = orgApiKey;
            UserJwt = userJwt;
            UserOrgJwt = userOrgJwt;
            UserOrgProjectJwt = userOrgProjectJwt;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UserOrgProjectJwt as object ??
            UserOrgJwt as object ??
            UserJwt as object ??
            OrgApiKey as object ??
            ProjectApiKey as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ProjectApiKey?.ToString() ??
            OrgApiKey?.ToString() ??
            UserJwt?.ToString() ??
            UserOrgJwt?.ToString() ??
            UserOrgProjectJwt?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsProjectApiKey && !IsOrgApiKey && !IsUserJwt && !IsUserOrgJwt && !IsUserOrgProjectJwt || !IsProjectApiKey && IsOrgApiKey && !IsUserJwt && !IsUserOrgJwt && !IsUserOrgProjectJwt || !IsProjectApiKey && !IsOrgApiKey && IsUserJwt && !IsUserOrgJwt && !IsUserOrgProjectJwt || !IsProjectApiKey && !IsOrgApiKey && !IsUserJwt && IsUserOrgJwt && !IsUserOrgProjectJwt || !IsProjectApiKey && !IsOrgApiKey && !IsUserJwt && !IsUserOrgJwt && IsUserOrgProjectJwt;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Together.WhoamiProjectApiKey, TResult>? projectApiKey = null,
            global::System.Func<global::Together.WhoamiOrgApiKey, TResult>? orgApiKey = null,
            global::System.Func<global::Together.WhoamiUserJwt, TResult>? userJwt = null,
            global::System.Func<global::Together.WhoamiUserOrgJwt, TResult>? userOrgJwt = null,
            global::System.Func<global::Together.WhoamiUserOrgProjectJwt, TResult>? userOrgProjectJwt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ProjectApiKey is { } __value0 && projectApiKey != null)
            {
                return projectApiKey(__value0);
            }
            else if (OrgApiKey is { } __value1 && orgApiKey != null)
            {
                return orgApiKey(__value1);
            }
            else if (UserJwt is { } __value2 && userJwt != null)
            {
                return userJwt(__value2);
            }
            else if (UserOrgJwt is { } __value3 && userOrgJwt != null)
            {
                return userOrgJwt(__value3);
            }
            else if (UserOrgProjectJwt is { } __value4 && userOrgProjectJwt != null)
            {
                return userOrgProjectJwt(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Together.WhoamiProjectApiKey>? projectApiKey = null,

            global::System.Action<global::Together.WhoamiOrgApiKey>? orgApiKey = null,

            global::System.Action<global::Together.WhoamiUserJwt>? userJwt = null,

            global::System.Action<global::Together.WhoamiUserOrgJwt>? userOrgJwt = null,

            global::System.Action<global::Together.WhoamiUserOrgProjectJwt>? userOrgProjectJwt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ProjectApiKey is { } __value0)
            {
                projectApiKey?.Invoke(__value0);
            }
            else if (OrgApiKey is { } __value1)
            {
                orgApiKey?.Invoke(__value1);
            }
            else if (UserJwt is { } __value2)
            {
                userJwt?.Invoke(__value2);
            }
            else if (UserOrgJwt is { } __value3)
            {
                userOrgJwt?.Invoke(__value3);
            }
            else if (UserOrgProjectJwt is { } __value4)
            {
                userOrgProjectJwt?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Together.WhoamiProjectApiKey>? projectApiKey = null,
            global::System.Action<global::Together.WhoamiOrgApiKey>? orgApiKey = null,
            global::System.Action<global::Together.WhoamiUserJwt>? userJwt = null,
            global::System.Action<global::Together.WhoamiUserOrgJwt>? userOrgJwt = null,
            global::System.Action<global::Together.WhoamiUserOrgProjectJwt>? userOrgProjectJwt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ProjectApiKey is { } __value0)
            {
                projectApiKey?.Invoke(__value0);
            }
            else if (OrgApiKey is { } __value1)
            {
                orgApiKey?.Invoke(__value1);
            }
            else if (UserJwt is { } __value2)
            {
                userJwt?.Invoke(__value2);
            }
            else if (UserOrgJwt is { } __value3)
            {
                userOrgJwt?.Invoke(__value3);
            }
            else if (UserOrgProjectJwt is { } __value4)
            {
                userOrgProjectJwt?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ProjectApiKey,
                typeof(global::Together.WhoamiProjectApiKey),
                OrgApiKey,
                typeof(global::Together.WhoamiOrgApiKey),
                UserJwt,
                typeof(global::Together.WhoamiUserJwt),
                UserOrgJwt,
                typeof(global::Together.WhoamiUserOrgJwt),
                UserOrgProjectJwt,
                typeof(global::Together.WhoamiUserOrgProjectJwt),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(WhoamiResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Together.WhoamiProjectApiKey?>.Default.Equals(ProjectApiKey, other.ProjectApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.WhoamiOrgApiKey?>.Default.Equals(OrgApiKey, other.OrgApiKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.WhoamiUserJwt?>.Default.Equals(UserJwt, other.UserJwt) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.WhoamiUserOrgJwt?>.Default.Equals(UserOrgJwt, other.UserOrgJwt) &&
                global::System.Collections.Generic.EqualityComparer<global::Together.WhoamiUserOrgProjectJwt?>.Default.Equals(UserOrgProjectJwt, other.UserOrgProjectJwt)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WhoamiResponse obj1, WhoamiResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WhoamiResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WhoamiResponse obj1, WhoamiResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WhoamiResponse o && Equals(o);
        }
    }
}
