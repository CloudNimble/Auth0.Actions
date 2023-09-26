import { PostLoginEvent, PostLoginApi } from "../Auth0.Actions.TypeScript/index";
import { nameof } from "ts-simple-nameof"
;

export function TestAuth(event: PostLoginEvent<MySecrets, {}, MyAppMetadata, MyUserMetadata>, api: PostLoginApi): void {
    api.user.setAppMetadata(nameof<MyUserMetadata>(c => c.defaultTheme), "test");
}


interface MySecrets {
    test_secret: string
}

interface MyAppMetadata {
    appUserId: string
}

interface MyUserMetadata {
    defaultTheme: string
}