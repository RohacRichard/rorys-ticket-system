import { Injectable } from '@angular/core';
import jwt_decode from 'jwt-decode'; 

const TOKEN_KEY = 'auth-token';
const USER_KEY = 'auth-user';
const ROLE_KEY = 'auth-roles';

@Injectable({
  providedIn: 'root'
})
export class TokenStorageService {
  constructor() { }

  signOut(): void {
    window.sessionStorage.clear();
  }

  public saveToken(token: string): void {
    window.sessionStorage.removeItem(TOKEN_KEY);
    window.sessionStorage.setItem(TOKEN_KEY, token);
  }

  public getToken(): string | null {
    return window.sessionStorage.getItem(TOKEN_KEY);
  }

  public saveUser(user: any): void {
    window.sessionStorage.removeItem(USER_KEY);
    window.sessionStorage.setItem(USER_KEY, JSON.stringify(user));
  }

  public saveRoles(jwtToken: string): void {
    var decodedJwtToken: any = jwt_decode(jwtToken);

    window.sessionStorage.removeItem(ROLE_KEY);
    window.sessionStorage.setItem(ROLE_KEY, decodedJwtToken.role);
  }

  public getRoles(): string[] {
    const roles = window.sessionStorage.getItem(ROLE_KEY);

    if (roles) {
      return roles.split(',');
    }

    return [];
  }

  public getUser(): any {
    const user = window.sessionStorage.getItem(TOKEN_KEY);
    if (user) {
      return jwt_decode(user);
    }

    return {};
  }
}