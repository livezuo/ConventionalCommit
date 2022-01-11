import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'ConventionalCommit',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44373',
    redirectUri: baseUrl,
    clientId: 'ConventionalCommit_App',
    responseType: 'code',
    scope: 'offline_access ConventionalCommit',
  },
  apis: {
    default: {
      url: 'https://localhost:44373',
      rootNamespace: 'ConventionalCommit',
    },
  },
} as Environment;
