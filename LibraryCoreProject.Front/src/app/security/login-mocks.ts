import { AppUserAuth } from './app-user-auth';

export const LOGIN_MOCKS: AppUserAuth[] = [
    {
        userName: "Admin",
        barerToken: "abcdef123456",
        isAuthenticated: true,
        canAccessBookDetails: true,
        canAccessBooks: true,
        canAddBook: true,
        canSaveBook: true,
        canDeleteBook: false
    },
    {
        userName: "User",
        barerToken: "qwerty098765",
        isAuthenticated: true,
        canAccessBookDetails: false,
        canAccessBooks: true,
        canAddBook: false,
        canSaveBook: false,
        canDeleteBook: false
    }
]