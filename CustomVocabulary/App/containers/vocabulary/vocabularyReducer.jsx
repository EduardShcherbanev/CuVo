import { GET_POSTS_SUCCESS, GET_POSTS_ERROR } from './vocabularyConstants.jsx'

const initialState = {
    data: { records: [] },
    error: ''
}

export default function vocabulary(state = initialState, action) {
    switch (action.type) {
        case GET_POSTS_SUCCESS:
            return { ...state, data: action.payload, error: '' }

        case GET_POSTS_ERROR:
            return { ...state, error: action.payload }

        default:
            return state;
    }
}