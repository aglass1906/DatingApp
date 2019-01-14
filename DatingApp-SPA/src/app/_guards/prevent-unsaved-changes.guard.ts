import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanDeactivate, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { MembersEditComponent } from '../members/members-edit/members-edit.component';


@Injectable()
export class PreventUnsavedChanges implements CanDeactivate<MembersEditComponent> {

    canDeactivate(component: MembersEditComponent) {
        if (component.editForm.dirty) {
            return confirm('Are you sure you want to continue?  Any usaved changes will be lost');
        }
        return true;
    }
}
