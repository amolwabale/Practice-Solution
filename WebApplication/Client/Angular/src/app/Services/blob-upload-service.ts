import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UtilityService } from './Common/utility.service';

@Injectable({
  providedIn: 'root'
})
export class BlobUploadService {

  constructor(private httpClient: HttpClient, private utilityService: UtilityService) {}

  /**
   * Gets a SAS URL from the API for the given filename.
   * @param filename Name of the file to upload
   */
  getSasUrl(filename: string): Observable<{ url: string }> {
    return this.httpClient.get<{ url: string }>(`${this.utilityService.baseUrl}api/GetUploadSasUrl?filename=${filename}`);
  }

  /**
   * Uploads a file directly to Blob Storage using a pre-signed SAS URL.
   * @param sasUrl The pre-signed URL for uploading
   * @param file The actual file object
   */
  uploadToBlob(sasUrl: string, file: File): Observable<any> {
    const headers = new HttpHeaders({ 'x-ms-blob-type': 'BlockBlob' });
    return this.httpClient.put(sasUrl, file, { headers, responseType: 'text' });
  }

}
