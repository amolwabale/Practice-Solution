import { Component } from '@angular/core';
import { BlobUploadService } from '../../Services/blob-upload-service';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-blobupload',
  imports: [CommonModule, HttpClientModule],
  templateUrl: './blobupload.component.html',
  styleUrl: './blobupload.component.css',
  providers:[BlobUploadService]
})
export class BlobuploadComponent {

  selectedFile: File | null = null;

  constructor(private blobUploadService: BlobUploadService) {}

  onFileSelected(event: any): void {
    this.selectedFile = event.target.files[0];
  }

  async upload(): Promise<void> {
    if (!this.selectedFile) {
      alert('Please select a file');
      return;
    }

    try {
      const fileName = this.selectedFile.name;

      // Step 1: Get SAS URL
      const sasResponse = await this.blobUploadService.getSasUrl(fileName).toPromise();
      const sasUrl = sasResponse?.url;
      if (!sasUrl) throw new Error('Failed to get SAS URL');

      // Step 2: Upload the file to blob
      await this.blobUploadService.uploadToBlob(sasUrl, this.selectedFile).toPromise();

      alert('Upload successful!');
    } catch (error) {
      console.error(error);
      alert('Upload failed.');
    }
  }
}
