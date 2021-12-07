import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Constants } from "./config/constants";

export interface TimerTask {
  id: string;
  userId: string;
  groupId: string;
  groupName: string;
  name: string;
  averageTime: any;
  energy: string;
  notes: string;
  icon: string;
  favorite: boolean;
  listOrder: number;
  history: TaskHistory[];
  tags: any;
  createDate: Date;
  editDate: Date;
}

export interface TaskHistory {
  id: string;
  userId: string;
  taskId: string;
  recordedTime: any;
  notes: string;
  outlier: boolean;
  createDate: Date;
  editDate: Date;
}

@Injectable({
  providedIn: "root",
})
export class TasksService {
  constructor(private http: HttpClient) {}

  getTasks(): TimerTask[] {
    return [];
  }
}
