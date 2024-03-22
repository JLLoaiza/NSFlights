export class APIResponse<T> {
    value?: T;
    isSuccess: boolean;
    message?: string;

    constructor(isSuccess: boolean, message?: string, value?: T) {
        this.value = value;
        this.isSuccess = isSuccess || false;
        this.message = message;
    }
}