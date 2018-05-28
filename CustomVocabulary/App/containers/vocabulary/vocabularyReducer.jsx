import { GET_VOCABULARY_SUCCESS, GET_VOCABULARY_ERROR } from './vocabularyConstants.jsx'

const initialState = {
    data: [],
    error: ''
}

export default function vocabulary(state = initialState, action) {
    switch (action.type) {
        case GET_VOCABULARY_SUCCESS:
            return { ...state, data: action.payload, error: '' }

        case GET_VOCABULARY_ERROR:
            return { ...state, error: action.payload }

        default:
            return state;
    }
}