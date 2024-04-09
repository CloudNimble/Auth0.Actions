
//#region Events

/**
 * 
 */
export interface CredentialsExchangeEvent<TSecret, TClientMetadata, TRequest extends CredentialsExchangeRequestBody> {

    /** An object containing information describing the authorization granted to the user who is logging in. */
    accessToken?: AccessToken;

    /**  */
    client?: Client<TClientMetadata>;

    /**  */
    request?: RequestBase<TRequest>;

    /**  */
    resource_server?: ResourceServer;

    /**  */
    secrets?: TSecret;

    /**  */
    tenant?: Tenant;

    /**  */
    transaction?: TransactionBase;

}

/**
 * 
 */
export interface PostLoginEvent<TSecret, TClientMetadata, TAppMetadata, TUserMetadata> {

    /** Details about authentication signals obtained during the login flow. */
    authentication?: AuthenticationInfoWithRiskAssessment

    /** An object containing information describing the authorization granted to the user who is logging in. */
    authorization?: AuthorizationInfo;

    /**  */
    client?: Client<TClientMetadata>;

    /**  */
    configuration?: Configuration;

    /**  */
    connection?: Connection;

    /**  */
    organization?: Organization;

    /**  */
    request?: Request<any>;

    /**  */
    resource_server?: ResourceServer;

    /**  */
    secrets?: TSecret;

    /**  */
    stats?: Stats;

    /**  */
    tenant?: Tenant;

    /**  */
    transaction?: Transaction;

    /**  */
    user?: UserBase<TAppMetadata, TUserMetadata>;
}

/**
 * 
 */
export interface AccessToken {

    customClaims: any;
    scope: string[];
}

/**
 * Details about authentication signals obtained during the login flow.
 */
export interface AuthenticationInfoWithRiskAssessment {

    /** Contains the authentication methods a user has completed during their session. */
    methods: AuthenticationMethod[];

    riskAssessment?: RiskAssessmentSummary;
}

/**
 * 
 */
export interface AuthenticationMethod {
    /**
     * The name of the first factor that was completed. Values include the following:
     */
    name: AuthenticationMethods | string;

    timestamp: string;

    /* A specific MFA factor. Only present when name is set to 'mfa'. */
    type: string;
}

/**
 * 
 */
export enum AuthenticationMethods {

    /** A social or enterprise connection was used to authenticate the user as the first factor. */
    federated = 'federated',

    /**  */
    passkey = 'passkey',

    /** A database connection was used to authenticate the user as the first factor. */
    pwd = 'pwd',

    /** A Passwordless SMS connection was used to authenticate the user as the first factor. */
    sms = 'sms',

    /** A Passwordless Email connection was used to authenticate the user as the first factor or verify email for password reset. */
    email = 'email',

    /**  */
    mfa = 'mfa',

    /* "Used for internal testing. */
    mock = 'mock'
}

/**
 * 
 */
export interface AuthorizationInfo {
    roles: string[];
}

/**
 * 
 */
export interface Client<TMetadata> {

    /** The client id of the application the user is logging in to. */
    clientId: string;

    /** An object for holding other application properties. */
    metadata: TMetadata

    /** The name of the application (as defined in the Dashboard). */
    name: string;

    /**  */
    strategy: string;
}

/**
 * 
 */
export interface Configuration {

}

/**
 * 
 */
export interface Connection {

    /**
     * The connection's identifier
    */
    id: string;

    /**
     * Metadata associated with the connection in the form of an object with string values (max 255 chars).  Maximum of 10 metadata properties allowed.
     */
    metadata: { [key: string]: any };

    /**
     * The name of the connection
     */
    name: string;

    /**
     * The type of the connection, related to the identity provider
     */
    strategy: ConnectionStrategies;

}

/**
 * 
 */
export enum ConnectionStrategies {
    ad = 'ad',
    adfs = 'adfs',
    amazon = 'amazon',
    apple = 'apple',
    dropbox = 'dropbox',
    bitbucket = 'bitbucket',
    aol = 'aol',
    auth0_oidc = 'auth0-oidc',
    auth0 = 'auth0',
    baidu = 'baidu',
    bitly = 'bitly',
    box = 'box',
    custom = 'custom',
    daccount = 'daccount',
    dwolla = 'dwolla',
    email = 'email',
    evernote_sandbox = 'evernote-sandbox',
    evernote = 'evernote',
    exact = 'exact',
    facebook = 'facebook',
    fitbit = 'fitbit',
    flickr = 'flickr',
    github = 'github',
    google_apps = 'google-apps',
    google_oauth2 = 'google-oauth2',
    instagram = 'instagram',
    ip = 'ip',
    line = 'line',
    linkedin = 'linkedin',
    miicard = 'miicard',
    oauth1 = 'oauth1',
    oauth2 = 'oauth2',
    office365 = 'office365',
    oidc = 'oidc',
    okta = 'okta',
    paypal = 'paypal',
    paypal_sandbox = 'paypal-sandbox',
    pingfederate = 'pingfederate',
    planningcenter = 'planningcenter',
    renren = 'renren',
    salesforce_community = 'salesforce-community',
    salesforce_sandbox = 'salesforce-sandbox',
    salesforce = 'salesforce',
    samlp = 'samlp',
    sharepoint = 'sharepoint',
    shopify = 'shopify',
    sms = 'sms',
    soundcloud = 'soundcloud',
    thecity_sandbox = 'thecity-sandbox',
    thecity = 'thecity',
    thirtysevensignals = 'thirtysevensignals',
    twitter = 'twitter',
    untappd = 'untappd',
    vkontakte = 'vkontakte',
    waad = 'waad',
    weibo = 'weibo',
    windowslive = 'windowslive',
    wordpress = 'wordpress',
    yahoo = 'yahoo',
    yammer = 'yammer',
    yandex = 'yandex',
}

/**
 * 
 */
export interface CredentialsExchangeRequestBody {
    audience: string;
    client_id: string;
    client_secret: string;
    grant_type: string;
}

/**
 * 
 */
export interface GeoIP {
    cityName: string
    continentCode: string
    countryCode3: string
    countryCode: string
    countryName: string
    latitude: number
    longitude: number
    subdivisionCode: string
    subdivisionName: string
    timeZone: string
}

/**
 * 
 */
export interface Identity {
    connection: string
    isSocial: boolean
    provider: string
    userId: string
    user_id: string
}

/**
 * 
 */
export interface IPAddressDetails {
    category: string;
    ip: string;
    matches: string;
    source: string;
}

/**
 * 
 */
export interface NewDeviceDetails {
    device: string;
    useragent: string;
}

/**
 * 
 */
export interface Organization {

    /* The friendly name of the Organization. */
    display_name: string;

    /**
     * The Organization's identifier.
    */
    id: string;

    /**
     * Metadata associated with the Organization.
     */
    metadata: { [key: string]: any };

    /**
     * The name of the Organization.
     */
    name: string;

}

/**
 * 
 */
export interface Query {
    audience: string
    client_id: string
    code_challenge: string
    code_challenge_method: string
    prompt: string
    redirect_uri: string
    response_mode: string
    response_type: string
    scope: string
    state: string
}

/**
 * 
 */
export interface Request<TBody> extends RequestBase<TBody> {
    query: Query;
}

/**
 * 
 */
export interface RequestBase<TBody> {
    body: TBody;
    geoip: GeoIP;
    hostname: string;
    ip: string;
    method: string;
    user_agent: string;
}

/**
 * 
 */
export interface ResourceServer {
    identifier: string
}

export interface RiskAssessmentBase {

    code: string;

    confidence: string;
}

/**
 * 
 */
export interface RiskAssessmentSummary {
    assessments: RiskAssessments;
    confidence: "low" | "medium" | "high" | "neutral";
    version: string;
}

/**
 * 
 */
export interface RiskAssessments {

    ImpossibleTravel: RiskAssessmentBase;

    NewDevice: RiskAssessmentWithDetails<NewDeviceDetails>

    UntrustedIP: RiskAssessmentWithDetails<IPAddressDetails>
}

/**
 * 
 */
export interface RiskAssessmentWithDetails<TDetails> {

    details: TDetails;
}

/**
 * 
 */
export interface Stats {
    logins_count: number
}

/**
 * 
 */
export interface Tenant {
    id: string
}

/**
 * 
 */
export interface Transaction extends TransactionBase {
    acr_values: any[]
    linking_id?: string
    locale: string
    login_hint?: string
    prompt: string[]
    protocol?: TransactionProtocols
    redirect_uri?: string
    response_mode?: string
    response_type?: string[]
    state?: string
    ui_locales: string[]
}

/**
 * 
 */
export interface TransactionBase {
    requested_scopes: string[]
}

/**
 * 
 */
export enum TransactionProtocols {
    oidc_basic = 'oidc-basic-profile',
    /*  Allows your application to have immediate access to an ID token while still providing for secure and safe retrieval of access and refresh tokens. */
    oidc_hybrid = 'oidc-hybrid',
    oidc_implicit = 'oidc-implicit-profile',
    samlp = 'samlp',
    wsfed = 'wsfed',
    wstrust_usernamemixed = 'wstrust-usernamemixed',
    oauth2_device_code = 'oauth2-device-code',
    oauth2_resource_owner = 'oauth2-resource-owner',
    oauth2_jwt_bearer = 'oauth2-resource-owner-jwt-bearer',
    oauth2_password = 'oauth2-password',
    oauth2_access_token = 'oauth2-access-token',
    oauth2_refresh_token = 'oauth2-refresh-token',
    oauth2_token_exchange = 'oauth2-token-exchange',
}

/**
 * 
 */
export interface UserBase<TAppMetadata, TUserMetadata> {

    /** Data that the user has read-only access to (e.g. roles, permissions, vip, etc) */
    app_metadata: TAppMetadata

    /**  */
    created_at: string

    /**  */
    email: string

    /**  */
    email_verified: boolean

    /**  */
    family_name: string

    /**  */
    given_name: string

    /**  */
    identities: Identity[]

    /**  */
    last_password_reset?: string

    /**  */
    multifactor?: string[]

    /**  */
    name: string

    /**  */
    nickname: string

    /**  */
    phone_number?: string

    /**  */
    phone_verified?: boolean

    /**  */
    picture: string

    /**  */
    updated_at: string

    /**  */
    user_id: string

    /** Data that the user has read/write access to (e.g. color_preference, blog_url, etc.) */
    user_metadata: TUserMetadata

    /**  */
    username?: string
}

//#endregion

//#region Actions APIs

export interface PostLoginApi extends ActionsApiBase<PostLoginApi> {

    /** Modify the user's login access, such as by rejecting the login attempt. */
    access: LoginAccessManager<PostLoginApi>;

    /** Request changes to the access token being issued. */
    accessToken: AccessTokenManager<PostLoginApi>;

    /**  */
    authentication: AuthenticationManager;

    /** Store and retrieve data that persists across executions. */
    cache: CacheManager;

    /** Request changes to the ID token being issued. */
    idToken: IdTokenManager;

    /**  */
    multifactor: MultifactorManager;

    /**  */
    redirect: RedirectManager;

    /**  */
    user: UserManager;
}

export interface AccessTokenManager<TApi extends ActionsApiBase<TApi>> extends AccessTokenManagerBase<TApi> {

    /**
     * Add a scope on the Access Token that will be issued upon completion of the login flow.
     * @param scope The scope to be added.
     */
    addScope(scope: string): TApi;

    /**
     * Remove a scope on the Access Token that will be issued upon completion of the login flow.
     * @param scope The scope to be removed.
     */
    removeScope(scope: string): TApi;

}

export interface AccessTokenManagerBase<TApi extends ActionsApiBase<TApi>> {

    /**
     * Set a custom claim on the Access Token that will be issued upon completion of the login flow.
     * @param name Name of the claim (note that this may need to be a fully-qualified URL).
     * @param value The value of the claim.
     */
    setCustomClaim(name: string, value: any): TApi;
}

export interface ActionsApiBase<TApi extends ActionsApiBase<TApi>> {

    /** Modify the user's login access, such as by rejecting the login attempt. */
    access: LoginAccessManager<TApi>;

    /** Request changes to the access token being issued. */
    accessToken: AccessTokenManagerBase<TApi>;

    /** Store and retrieve data that persists across executions. */
    cache: CacheManager;

}

export interface AuthenticationManager {

    /**
     * Indicate that a custom authentication method has been completed in the current session. This method will then be available in the 
     * `event.authentication.methods` array in subsequent logins.
     * 
     * Important: This API is only available from within the onContinuePostLogin function for PostLogin Actions. In other words, this may 
     * be used to record the completion of a custom authentication method after redirecting the user via api.redirect.sendUserTo().
     *
     * @param provider_url
     */
    recordMethod(provider_url: string): PostLoginApi;

    /**
     * Challenge the user with one or more specified multifactor authentication factors. This method presents the default challenge first,
     * then allows the user to select a different option if additional factors have been supplied. If the user has not enrolled in any of 
     * the factors supplied (including both the default and any additional factors), the command fails.
     * 
     * Note: This method overrides existing policies and rules that enable or disable MFA in a tenant.
     * @param factor Used to specify the default MFA factor or factors used to challenge the user.
     * @param options An object containing the optional additionalFactors field.
     */
    challengeWith(factor: ChallengeFactor, options: ChallengeOptions): void

    /**
     * Trigger an MFA challenge and allow the user to select their preferred factor from the supplied list. This method presents a factor picker to the user rather than a specific challenge, in accordance with the following conditions:
     * - If two or more factors are specified, a factor picker displays to the user.
     * - If the user has only enrolled in one of the specified factors (or only one factor is specified), the factor picker is skipped.
     * - If the user has not enrolled in any of the specified factors, the challenge command fails.
     * Note: This method overrides existing policies and rules that enable or disable MFA in a tenant.
     * @param factors
     */
    challengeWithAny(factors: ChallengeFactor[]): void
}

export interface CacheManager {

    /**
     * Delete a record describing a cached value at the supplied key if it exists.
     * @param key
     */
    delete(key: string): CacheWriteResult;

    /**
     * Retrieve a record describing a cached value at the supplied key, if it exists. If a record is found, the cached value can be found at the value 
     * property of the returned object.
     * @param key The key of the record stored in the cache.
     */
    get(key: string): CacheRecord

    /**
     * 
     * @param key The value of the record to be stored.
     * @param value The value of the record to be stored.
     * @param options Options for adjusting cache behavior.
     */
    set(key: string, value: any, options?: CacheOptions): void

}

export interface CacheWriteResult {

    /**  */
    type: 'success' | 'error'

    /** If @see type = 'error', then the error code will be populated here. */
    code: string
}

export interface CacheRecord {

    /** The object stored in the Cache. */
    value: any

    /** The maximum expiry of the record in milliseconds since the Unix epoch. */
    expires_at: number
}

export interface CacheOptions {

    /**
     * The absolute expiry time in milliseconds since the unix epoch. While cached records may be evicted earlier, they will never remain beyond the the supplied expires_at.
     * NOTE: This value should not be supplied if a value was also provided for ttl. If both options are supplied, the earlier expiry of the two will be used.
     */
    expires_at?: number

    /**
     * The time-to-live value of this cache entry in milliseconds. While cached values may be evicted earlier, they will never remain beyond the the supplied ttl.
     * NOTE: This value should not be supplied if a value was also provided for expires_at. If both options are supplied, the earlier expiry of the two will be used.
     */
    ttl?: number
}

export interface ChallengeFactor {
    type: ChallengeTypes

    /** 
     * When set to true, the user cannot use the OTP fallback option of the push notification factor. (Developer's note: This makes no sense.)
     * Only used for @see ChallengeTypes.push_notification.
     */
    otpFallback?: boolean

    /**
     * Only used for @see ChallengeTypes.phone.
     */
    preferredMethod?: 'voice' | 'phone' | 'both'
}

export interface ChallengeOptions {
    additionalFactors: ChallengeFactor[]
}

export enum ChallengeTypes {
    otp = 'otp',
    email = 'email',
    phone = 'phone',
    push_notification = 'push-notification',
    webauthn_platform = 'webauthn-platform',
    webauthn_roaming = 'webauthn-roaming'
}

export interface CredentialsExchangeApi extends ActionsApiBase<CredentialsExchangeApi> {

    /** Control availability to the access token. */
    access: LoginAccessManager<CredentialsExchangeApi>;

    /** Request changes to the access token being issued. */
    accessToken: AccessTokenManagerBase<CredentialsExchangeApi>;

    /** Store and retrieve data that persists across executions. */
    cache: CacheManager;

}

export interface DuoMultifactorOptions {
    host: string
    ikey: string
    skey: string
}

export interface EncodeTokenOptions {
    expiresInSeconds: number
    payload: any;

    /** 
     * A secret that will be used to sign a JWT that is shared with the redirect target. 
     * The secret value should be stored as a secret and retrieved using event.secrets['SECRET_NAME']
     */
    secret: string;
}

export interface IdTokenManager {

    /**
     * Set a custom claim on the ID token that will be issued upon completion of the login flow.
     * @param name Name of the claim (note that this may need to be a fully-qualified URL).
     * @param value The value of the claim.
     */
    setCustomClaim(name: string, value: any): PostLoginApi
}

export interface LoginAccessManager<TApi extends ActionsApiBase<TApi>> {

    /**
     * Mark the current login attempt as denied. This will prevent the end-user from completing the login flow. This will NOT cancel other user-related 
     * side effects (such as metadata changes) requested by this Action. The login flow will immediately stop following the completion of this action 
     * and no further Actions will be executed.
     * @param reason A human-readable explanation for rejecting the login. This may be presented directly in end-user interfaces.
     */
    deny(reason: string): TApi;
}

export interface MultifactorManager {

    /**
     * 
     * @param provider
     * @param options
     */
    enable(provider: 'any' | 'duo' | 'google-authenticator' | 'guardian' | 'none', options: MultifactorOptions): PostLoginApi
}

export interface MultifactorOptions {
    allowRememberBrowser?: boolean
    providerOptions?: DuoMultifactorOptions
}

export interface RedirectManager {

    /**
     * 
     * @param options
     */
    encodeToken(options: EncodeTokenOptions): string

    /**
     * 
     * @param url
     * @param options
     */
    sendUserTo(url: string, options: { query: string }): PostLoginApi

    /**
     * 
     * @param options
     */
    validateToken(options: ValidateTokenOptions): string
}

export interface UserManager {

    /**
     * 
     * @param name
     * @param value
     */
    setAppMetadata(name: string, value: any): PostLoginApi

    /**
     * 
     * @param name
     * @param value
     */
    setUserMetadata(name: string, value: any): PostLoginApi
}

export interface ValidateTokenOptions {
    secret: string;
    tokenParameterName: string;
}

//#endregion
