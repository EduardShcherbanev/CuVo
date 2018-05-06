import { GET_POSTS_SUCCESS, GET_POSTS_ERROR } from './vocabularyConstants.jsx'

const initialState = {
    data: { records: [] },
    error: ''
}

export default function vocabulary(state = initialState, action) {
    switch (action.type) {
    case GET_POSTS_SUCCESS:
        return { ...state, data: action.posts, error: '' }

    case GET_POSTS_ERROR:
        return { ...state, error: action.error }

    default:
        return state;
    }
}