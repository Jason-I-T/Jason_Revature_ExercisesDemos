import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { DashboardComponent } from './dashboard/dashboard.component';
import { HeroesComponent } from './heroes/heroes.component';
import { HeroDetailComponent } from './hero-detail/hero-detail.component';

const routes: Routes=[
  { path: '', redirectTo: '/dashboard', pathMatch: 'full'},
  { path: 'heroes', component: HeroesComponent},
  { path: 'dashboard', component: DashboardComponent},
  { path: 'detail/:id', component: HeroDetailComponent}, // Colon says that this is a placeholer 
];

// Initializes the router, listens for browser location changes
@NgModule({ 
  /* 
  Adds RouterModule to AppRoutingModule imports array & configures with routes in one step.
  Called forRoot b/c configure router at app's root level. Gives data needed for routing, performs 
  initial navibation based on current browser URL 
  */
  imports: [RouterModule.forRoot(routes)],
  // Makes RouterModule to be available throught the application
  exports: [RouterModule]
})

// Add this module to the imports array in app.module.ts to make it work
export class AppRoutingModule { }
