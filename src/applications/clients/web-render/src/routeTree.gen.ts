/* prettier-ignore-start */

/* eslint-disable */

// @ts-nocheck

// noinspection JSUnusedGlobalSymbols

// This file is auto-generated by TanStack Router

import { createFileRoute } from '@tanstack/react-router'

// Import Routes

import { Route as rootRoute } from './routes/__root'
import { Route as ExchangesInternalNameImport } from './routes/exchanges/$internalName'

// Create Virtual Routes

const IndexLazyImport = createFileRoute('/')()
const ExchangesIndexLazyImport = createFileRoute('/exchanges/')()
const AccountRegisterLazyImport = createFileRoute('/account/register')()
const AccountLoginLazyImport = createFileRoute('/account/login')()

// Create/Update Routes

const IndexLazyRoute = IndexLazyImport.update({
  path: '/',
  getParentRoute: () => rootRoute,
} as any).lazy(() => import('./routes/index.lazy').then((d) => d.Route))

const ExchangesIndexLazyRoute = ExchangesIndexLazyImport.update({
  path: '/exchanges/',
  getParentRoute: () => rootRoute,
} as any).lazy(() =>
  import('./routes/exchanges/index.lazy').then((d) => d.Route),
)

const AccountRegisterLazyRoute = AccountRegisterLazyImport.update({
  path: '/account/register',
  getParentRoute: () => rootRoute,
} as any).lazy(() =>
  import('./routes/account/register.lazy').then((d) => d.Route),
)

const AccountLoginLazyRoute = AccountLoginLazyImport.update({
  path: '/account/login',
  getParentRoute: () => rootRoute,
} as any).lazy(() => import('./routes/account/login.lazy').then((d) => d.Route))

const ExchangesInternalNameRoute = ExchangesInternalNameImport.update({
  path: '/exchanges/$internalName',
  getParentRoute: () => rootRoute,
} as any)

// Populate the FileRoutesByPath interface

declare module '@tanstack/react-router' {
  interface FileRoutesByPath {
    '/': {
      preLoaderRoute: typeof IndexLazyImport
      parentRoute: typeof rootRoute
    }
    '/exchanges/$internalName': {
      preLoaderRoute: typeof ExchangesInternalNameImport
      parentRoute: typeof rootRoute
    }
    '/account/login': {
      preLoaderRoute: typeof AccountLoginLazyImport
      parentRoute: typeof rootRoute
    }
    '/account/register': {
      preLoaderRoute: typeof AccountRegisterLazyImport
      parentRoute: typeof rootRoute
    }
    '/exchanges/': {
      preLoaderRoute: typeof ExchangesIndexLazyImport
      parentRoute: typeof rootRoute
    }
  }
}

// Create and export the route tree

export const routeTree = rootRoute.addChildren([
  IndexLazyRoute,
  ExchangesInternalNameRoute,
  AccountLoginLazyRoute,
  AccountRegisterLazyRoute,
  ExchangesIndexLazyRoute,
])

/* prettier-ignore-end */
