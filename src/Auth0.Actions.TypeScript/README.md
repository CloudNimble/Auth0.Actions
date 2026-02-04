# auth0-actions

> **DEPRECATION NOTICE**: This package is now deprecated in favor of the official [@auth0/actions](https://www.npmjs.com/package/@auth0/actions) package from Auth0. Please migrate to the official package for better support and comprehensive coverage.

Type definitions and utilities for building Auth0 Actions.

## Installation

```bash
npm install auth0-actions
```

## Overview

This package provides TypeScript type definitions for Auth0 Actions, focusing on:
- **Credentials Exchange** actions
- **Post-Login** actions

The types are designed to help you build type-safe Auth0 Actions with proper intellisense support in your IDE.

## Basic Usage

```typescript
import { PostLoginEvent, PostLoginApi } from 'auth0-actions';

// Define your custom types
interface MySecrets {
  apiKey: string;
}

interface MyClientMetadata {
  clientType: string;
}

interface MyAppMetadata {
  roles: string[];
}

interface MyUserMetadata {
  preferences: {
    theme: string;
  };
}

// Your Post-Login action
export async function onExecutePostLogin(
  event: PostLoginEvent<MySecrets, MyClientMetadata, MyAppMetadata, MyUserMetadata>,
  api: PostLoginApi
) {
  const apiKey = event.secrets?.apiKey;
  const userRoles = event.user?.app_metadata.roles;

  if (!userRoles?.includes('admin')) {
    api.access.deny('User does not have admin role');
  }

  api.accessToken.setCustomClaim('https://my-app.com/roles', userRoles);
}
```

### Credentials Exchange Example

```typescript
import { CredentialsExchangeEvent, CredentialsExchangeApi, CredentialsExchangeRequestBody } from 'auth0-actions';

interface MySecrets {
  clientSecret: string;
}

interface MyClientMetadata {
  tier: string;
}

interface MyRequestBody extends CredentialsExchangeRequestBody {
  custom_param?: string;
}

export async function onExecuteCredentialsExchange(
  event: CredentialsExchangeEvent<MySecrets, MyClientMetadata, MyRequestBody>,
  api: CredentialsExchangeApi
) {
  const tier = event.client?.metadata.tier;

  if (tier === 'free') {
    api.access.deny('Free tier not allowed for this resource');
  }

  api.accessToken.setCustomClaim('https://my-app.com/tier', tier);
}
```

## Limitations

This package provides a simplified implementation focused on the most common Auth0 Actions use cases. It has several limitations:

1. **Limited Action Types**: Only covers Credentials Exchange and Post-Login actions
2. **No Versioning**: Does not support multiple API versions
3. **Incomplete Coverage**: Missing several action types available in Auth0
4. **Generic Approach**: Uses TypeScript generics instead of specific inline types

## Migration to Official Package

Auth0 now provides an official [@auth0/actions](https://www.npmjs.com/package/@auth0/actions) package that is:
- ✅ More comprehensive (12+ action types)
- ✅ Properly versioned (v1, v2, v3 for different APIs)
- ✅ Better typed with discriminated unions
- ✅ Officially maintained by Auth0
- ✅ Matches Auth0's actual API exactly

### Upgrade Guide

#### Step 1: Install the Official Package

```bash
npm uninstall auth0-actions
npm install @auth0/actions
```

#### Step 2: Update Your Imports

**Before (this package):**
```typescript
import { PostLoginEvent, PostLoginApi } from 'auth0-actions';

export async function onExecutePostLogin(
  event: PostLoginEvent<MySecrets, MyClientMetadata, MyAppMetadata, MyUserMetadata>,
  api: PostLoginApi
) {
  // Your code
}
```

**After (official package):**
```typescript
import type {
  PostLoginAction
} from '@auth0/actions/post-login/v3';

export const onExecutePostLogin: PostLoginAction = async (event, api) => {
  // Your code - the types are inferred automatically
  // No need for generic type parameters
};
```

#### Step 3: Property Name Changes

The official package uses consistent `snake_case` for all properties to match Auth0's API:

| This Package (deprecated) | Official Package |
|--------------------------|------------------|
| `event.client?.clientId` | `event.client.client_id` |
| `event.user?.user_metadata` | `event.user.user_metadata` ✓ (same) |
| Generic types | Inline types with specific versions |

#### Step 4: Handle Secrets and Configuration

**Before:**
```typescript
interface MySecrets {
  apiKey: string;
}

// Then used as generic parameter
PostLoginEvent<MySecrets, ...>
```

**After:**
```typescript
// Secrets are automatically typed
const apiKey = event.secrets.API_KEY; // string
```

For better type safety with secrets, you can augment the official types:

```typescript
import type { PostLoginAction } from '@auth0/actions/post-login/v3';

// Augment the Secrets interface
declare module '@auth0/actions/post-login/v3' {
  interface Secrets {
    API_KEY: string;
    DATABASE_URL: string;
  }
}

export const onExecutePostLogin: PostLoginAction = async (event, api) => {
  const apiKey = event.secrets.API_KEY; // Now typed as string
};
```

#### Step 5: Action Type Mapping

| This Package | Official Package |
|-------------|------------------|
| `CredentialsExchangeEvent` | `@auth0/actions/credentials-exchange/v2` |
| `PostLoginEvent` | `@auth0/actions/post-login/v3` |
| Not available | `@auth0/actions/post-user-registration/v2` |
| Not available | `@auth0/actions/pre-user-registration/v2` |
| Not available | `@auth0/actions/post-change-password/v2` |
| And more... | See [official docs](https://auth0.com/docs/customize/actions) |

### Complete Migration Example

**Before (this package):**
```typescript
import { PostLoginEvent, PostLoginApi } from 'auth0-actions';

interface Secrets {
  AUTH_SECRET: string;
}

export async function onExecutePostLogin(
  event: PostLoginEvent<Secrets, any, any, any>,
  api: PostLoginApi
) {
  const secret = event.secrets?.AUTH_SECRET;
  api.accessToken.setCustomClaim('role', event.user?.app_metadata.role);
}
```

**After (official package):**
```typescript
import type { PostLoginAction } from '@auth0/actions/post-login/v3';

declare module '@auth0/actions/post-login/v3' {
  interface Secrets {
    AUTH_SECRET: string;
  }
}

export const onExecutePostLogin: PostLoginAction = async (event, api) => {
  const secret = event.secrets.AUTH_SECRET;
  api.accessToken.setCustomClaim('role', event.user.app_metadata.role);
};
```

## Why Migrate?

1. **Official Support**: Maintained directly by Auth0
2. **Complete Coverage**: All action types, not just 2
3. **API Versioning**: Target specific API versions (v1, v2, v3)
4. **Better Types**: More accurate with discriminated unions and specific error codes
5. **Future-Proof**: Gets updates when Auth0 adds new features
6. **Better Documentation**: Integrated with Auth0's official documentation

## Resources

- [Official @auth0/actions Package](https://www.npmjs.com/package/@auth0/actions)
- [Auth0 Actions Documentation](https://auth0.com/docs/customize/actions)
- [Auth0 Actions Triggers](https://auth0.com/docs/customize/actions/triggers)
- [Actions Marketplace](https://marketplace.auth0.com/features/actions)

## Legacy API Reference

For those still using this package, basic API reference:

### Event Interfaces
- `PostLoginEvent<TSecret, TClientMetadata, TAppMetadata, TUserMetadata>`
- `CredentialsExchangeEvent<TSecret, TClientMetadata, TRequest>`

### API Interfaces
- `PostLoginApi` - Main API for post-login actions
- `CredentialsExchangeApi` - Main API for credentials exchange

### Managers
- `AccessTokenManager` - Modify access token
- `IdTokenManager` - Modify ID token
- `CacheManager` - Store/retrieve cached data
- `UserManager` - Update user metadata
- `MultifactorManager` - Configure MFA
- `RedirectManager` - Handle redirects
- `AuthenticationManager` - Record authentication methods

## License

MIT

## Author

CloudNimble, Inc. - opensource@nimbleapps.cloud

---

**Again, please migrate to [@auth0/actions](https://www.npmjs.com/package/@auth0/actions) for the best experience.**
